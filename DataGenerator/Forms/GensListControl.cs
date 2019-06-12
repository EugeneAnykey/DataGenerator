using EugeneAnykey.Project.DataGenerator.Generators;
using System;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public class GenItemAddEventArgs : EventArgs
	{
		BaseGen gen;
		public BaseGen Gen
		{
			get => gen;
			set
			{
				gen = value;
				Cancel = gen == null;
			}
		}

		public bool Cancel { get; private set; }

		public GenItemAddEventArgs(BaseGen gen)
		{
			Gen = gen;
		}
	}

	public delegate void GenItemAddEventHandler(object sender, GenItemAddEventArgs args);



	public partial class GensListControl : UserControl
	{
		// events
		public event EventHandler PassingItemToAdd;
		void OnPassingItemToAdd() => PassingItemToAdd?.Invoke(this, EventArgs.Empty);

		public event GenItemAddEventHandler AddingItem;
		void OnAddingItem(GenItemAddEventArgs args) => AddingItem?.Invoke(this, args);

		public event GenItemAddEventHandler ItemSelected;
		void OnItemSelected(GenItemAddEventArgs args) => ItemSelected?.Invoke(this, args);

		public event EventHandler RemovingItem;
		void OnRemovingItem() => RemovingItem?.Invoke(this, EventArgs.Empty);



		// init
		public GensListControl()
		{
			InitializeComponent();

			Init();
			InitEvent();
		}

		void Init()
		{
			UpdateCaption();
		}

		void InitEvent()
		{
			buttonAdd.Click += (_, __) => Add();
			buttonUp.Click += (_, __) => MoveItem(Direction.Up);
			buttonDown.Click += (_, __) => MoveItem(Direction.Down);
			buttonRemove.Click += (_, __) => Remove();

			listBox.SelectedIndexChanged += (_, __) => SelectedItem();
		}



		// MoveItem
		enum Direction { Up, Down }

		void MoveItem(Direction dir, bool toTheEdge = false)
		{
			if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
				return;

			if (NeedToMove(dir, toTheEdge, out int pos))
			{
				object selected = listBox.SelectedItem;
				listBox.Items.Remove(selected);
				listBox.Items.Insert(pos, selected);
				listBox.SetSelected(pos, true);
			}
		}

		bool NeedToMove(Direction dir, bool toTheEdge, out int pos)
		{
			pos = listBox.SelectedIndex;
			if (Direction.Up == dir)
			{
				if (IsIn(pos, 1, listBox.Items.Count - 1))
				{
					pos = toTheEdge ? 0 : pos - 1;
					return true;
				}
			}
			else if (Direction.Down == dir)
			{
				if (IsIn(pos, 0, listBox.Items.Count - 2))
				{
					pos = toTheEdge ? listBox.Items.Count - 1 : pos + 1;
					return true;
				}
			}
			return false;
		}

		bool IsIn(int val, int min, int max) => min <= val && val <= max;



		// Add
		void Add()
		{
			//OnPassingItemToAdd();
			var args = new GenItemAddEventArgs(null);
			OnAddingItem(args);

			//if (args.Cancel)
			if (args.Gen == null)
				return;

			listBox.Items.Add(args.Gen);
			
			UpdateCaption();
		}



		// Remove
		void Remove()
		{
			if (!(listBox.SelectedItem is BaseGen selected))
				return;

			listBox.Items.Remove(selected);
			UpdateCaption();
		}



		// SelectedItem
		void SelectedItem()
		{
			if (!(listBox.SelectedItem is BaseGen selected))
				return;

			var args = new GenItemAddEventArgs(selected);
			OnItemSelected(args);
		}



		// UpdateCaption
		void UpdateCaption() => groupBoxMain.Text = $"Count: {listBox.Items.Count}.";
	}
}
