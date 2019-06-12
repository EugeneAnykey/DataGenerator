using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class GensListControl : UserControl
	{
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
		}



		// MoveItem
		enum Direction { Up, Down }

		void MoveItem(Direction dir, bool toTheEdge = false)
		{
			var listBox = listBox1;

			if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
				return;

			bool needToMove = false;
			var pos = listBox.SelectedIndex;

			if (Direction.Up == dir)
			{
				if (IsIn(pos, 1, listBox.Items.Count - 1))
				{
					needToMove = true;
					pos = toTheEdge ? 0 : pos - 1;
				}
			}
			else
			if (Direction.Down == dir)
			{
				if (IsIn(pos, 0, listBox.Items.Count - 2))
				{
					needToMove = true;
					pos = toTheEdge ? listBox.Items.Count - 1 : pos + 1;
				}
			}

			if (needToMove)
			{
				object selected = listBox.SelectedItem;
				// Removing removable element
				listBox.Items.Remove(selected);
				// Insert it in new position
				listBox.Items.Insert(pos, selected);
				// Restore selection
				listBox.SetSelected(pos, true);
			}

		}

		bool IsIn(int val, int min, int max) => min <= val && val <= max;



		// Add
		void Add()
		{

			UpdateCaption();
		}



		// Remove
		void Remove()
		{

			UpdateCaption();
		}



		// UpdateCaption
		void UpdateCaption() => groupBoxMain.Text = $"Count: {listBox1.Items.Count}.";
	}
}
