using EugeneAnykey.Project.BlockLines.Types;

namespace EugeneAnykey.Project.BlockLines.Forms
{
    public partial class BlockLineControl : UserControl
    {
        const int TracksCount = 5;
        const string DefaultName = "Block line";
        readonly TrackAndLabel[] tracks = new TrackAndLabel[TracksCount];

        public BlockLineControl()
        {
            InitializeComponent();
            Init();

            buttonAsc.Visible = false;
            buttonHill.Visible = false;
        }

        void Init()
        {
            tracks[0] = new TrackAndLabel(trackBar1, label1, 1000);
            tracks[1] = new TrackAndLabel(trackBar2, label2, 3000);
            tracks[2] = new TrackAndLabel(trackBar3, label3, 5000);
            tracks[3] = new TrackAndLabel(trackBar4, label4, 7000);
            tracks[4] = new TrackAndLabel(trackBar5, label5, 9000);

            foreach (var track in tracks)
            {
                track.TrackBar.ValueChanged += UpdateTotal;
            }

            textBoxName.Text = DefaultName;
            UpdateTotal(this, EventArgs.Empty);
        }

        void UpdateTotal(object? sender, EventArgs e)
        {
            int summ = tracks.Select(t => t.TrackBar.Value).Sum();
            labelTotal.Text = $"Total value: {summ}";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            foreach (var track in tracks)
            {
                track.Reset();
            }

            textBoxName.Text = DefaultName;
        }


        public void SetItem(string name, int[] values)
        {
            textBoxName.Text = name;
            for (int i = 0; i < values.Length && i < TracksCount; i++)
            {
                tracks[i].SetValue(values[i]);
            }
        }

        public void SetItem(BlockLineItem? item)
        {
            if (item == null) { return; }

            textBoxName.Text = item.Name;

            int[] values = item.Values;
            for (int i = 0; i < values.Length && i < TracksCount; i++)
            {
                tracks[i].SetValue(values[i]);
            }
        }

        public BlockLineItem GetItem()
        {
            return new BlockLineItem(textBoxName.Text, tracks.Select(t => t.TrackBar.Value).ToArray());
        }
    }
}
