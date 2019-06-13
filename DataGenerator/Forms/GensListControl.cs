using System;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class GensListControl : UserControl
	{
		// events
		public event EventHandler PassingItemToAdd;
		void OnPassingItemToAdd() => PassingItemToAdd?.Invoke(this, EventArgs.Empty);

		public event GenItemAddEventHandler AddingItem;
		void OnAddingItem(GenItemAddEventArgs args) => AddingItem?.Invoke(this, args);

		public event GenItemEventHandler ItemSelected;
		void OnItemSelected(GenItemEventArgs args) => ItemSelected?.Invoke(this, args);

		public event GenItemEventHandler AddingRandomItem;
		void OnAddingRandomItem(GenItemEventArgs args) => AddingRandomItem?.Invoke(this, args);

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
			buttonAdd.Click += (_, __) => AddItem();
			buttonGenerateRandom.Click += (_, __) => AddRandomItem();
			buttonUp.Click += (_, __) => MoveItem(Direction.Up);
			buttonDown.Click += (_, __) => MoveItem(Direction.Down);
			buttonRemove.Click += (_, __) => RemoveItem();

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
		void AddItem()
		{
			var args = new GenItemAddEventArgs(null);
			OnAddingItem(args);

			if (args.Gen == null)
				return;

			AddItem(args.Gen);
		}

		void AddItem(BaseGen gen)
		{
			listBox.Items.Add(gen);
			UpdateCaption();
		}

		void AddRandomItem()
		{
			var args = new GenItemEventArgs(null);
			OnAddingRandomItem(args);

			if (args.Gen == null)
				return;

			AddItem(args.Gen);
		}



		// Remove
		void RemoveItem()
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

			OnItemSelected(new GenItemEventArgs(selected));
		}



		// public GetBaseGens
		public BaseGen[] GetBaseGens()
		{
			var res = new BaseGen[listBox.Items.Count];
			listBox.Items.CopyTo(res, 0);
			return res;
		}



		// UpdateCaption
		void UpdateCaption() => groupBoxMain.Text = $"Count: {listBox.Items.Count}.";
	}
}
