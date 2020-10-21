using System;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class GensListControl : UserControl
	{
		#region events
		public event EventHandler PassingItemToAdd;
		void OnPassingItemToAdd() => PassingItemToAdd?.Invoke(this, EventArgs.Empty);

		public event GenItemEventHandler AddingItem;
		void OnAddingItem(GenItemEventArgs args) => AddingItem?.Invoke(this, args);

		public event GenItemEventHandler ItemSelected;
		void OnItemSelected(GenItemEventArgs args) => ItemSelected?.Invoke(this, args);

		public event GenItemEventHandler AddingRandomItem;
		void OnAddingRandomItem(GenItemEventArgs args) => AddingRandomItem?.Invoke(this, args);

		public event GenItemEventHandler AddingMiscRandomItem;
		void OnAddingMiscRandomItem(GenItemEventArgs args) => AddingMiscRandomItem?.Invoke(this, args);

		public event EventHandler RemovingItem;
		void OnRemovingItem() => RemovingItem?.Invoke(this, EventArgs.Empty);
		#endregion


		#region enum: Direction, RandomType
		enum Direction { Up, Down }

		enum RandomType { Current, Misc }
		#endregion


		#region init
		public GensListControl()
		{
			InitializeComponent();

			Init();
			InitEvent();
		}

		void Init()
		{
			buttonNothing.Visible = false;
			UpdateCaption();
		}

		void InitEvent()
		{
			buttonAdd.Click += (_, __) => AddItem();
			buttonAddRandom.Click += (_, __) => AddRandomItem(RandomType.Current);
			buttonAddMiscRandom.Click += (_, __) => AddRandomItem(RandomType.Misc);
			buttonUp.Click += (_, __) => MoveItem(Direction.Up);
			buttonDown.Click += (_, __) => MoveItem(Direction.Down);
			buttonReplace.Click += (_, __) => ReplaceItem();
			buttonRemove.Click += (_, __) => RemoveItem();

			listBox.SelectedIndexChanged += (_, __) => SelectedItem();
		}
		#endregion


		#region public: GetBaseGens, SetBaseGens
		public BaseGen[] GetBaseGens()
		{
			var res = new BaseGen[listBox.Items.Count];
			listBox.Items.CopyTo(res, 0);
			return res;
		}

		public void SetBaseGens(BaseGen[] gens)
		{
			foreach (var g in gens)
			{
				listBox.Items.Add(g);
			}
			listBox.SelectedIndex = 0;
			UpdateCaption();
		}
		#endregion


		#region private: MoveItem, NeedToMove
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
				if (Helpers.IsIn(pos, 1, listBox.Items.Count - 1))
				{
					pos = toTheEdge ? 0 : pos - 1;
					return true;
				}
			}
			else if (Direction.Down == dir)
			{
				if (Helpers.IsIn(pos, 0, listBox.Items.Count - 2))
				{
					pos = toTheEdge ? listBox.Items.Count - 1 : pos + 1;
					return true;
				}
			}
			return false;
		}
		#endregion


		#region private: AddItem, AddRandomItem
		void AddItem()
		{
			var args = new GenItemEventArgs(null);
			OnAddingItem(args);

			if (args.Gen == null)
				return;

			AddItem(args.Gen);
		}

		void AddItem(BaseGen gen)
		{
			var pos = listBox.Items.Add(gen);
			listBox.SetSelected(pos, true);
			UpdateCaption();
		}

		void AddRandomItem(RandomType type)
		{
			var args = new GenItemEventArgs(null);
			switch (type)
			{
				case RandomType.Current:
					OnAddingRandomItem(args);
					break;
				case RandomType.Misc:
					OnAddingMiscRandomItem(args);
					break;
				default:
					break;
			}

			if (args.Gen == null)
				return;

			AddItem(args.Gen);
		}
		#endregion


		#region private: RemoveItem, ReplaceItem
		void RemoveItem()
		{
			if (!(listBox.SelectedItem is BaseGen selected))
				return;

			var index = listBox.Items.IndexOf(selected);
			listBox.Items.Remove(selected);
			UpdateCaption();

			if (listBox.Items.Count > 0)
				listBox.SelectedIndex = Helpers.MakeIn(index, 0, listBox.Items.Count - 1);
		}

		void ReplaceItem()
		{
			if (!(listBox.SelectedItem is BaseGen selected))
				return;

			var args = new GenItemEventArgs(null);
			OnAddingItem(args);

			if (args.Gen == null)
				return;

			var index = listBox.Items.IndexOf(selected);
			listBox.Items.Remove(selected);
			listBox.Items.Insert(index, args.Gen);
			listBox.SetSelected(index, true);
			UpdateCaption();
		}
		#endregion


		#region private: SelectedItem, UpdateCaption
		void SelectedItem()
		{
			if (!(listBox.SelectedItem is BaseGen selected))
				return;

			OnItemSelected(new GenItemEventArgs(selected));
		}

		void UpdateCaption() => groupBoxMain.Text = $"Count: {listBox.Items.Count}.";
		#endregion
	}
}
