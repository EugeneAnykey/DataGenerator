namespace EugeneAnykey.Project.BlockLines.Types
{
    struct TrackAndLabel
    {
        const int MinValue = 0;
        const int MaxValue = 10000;
        const bool ShowTicks = true;

        public TrackBar TrackBar;
        public Label Label;
        private readonly int DefaultValue;

        public TrackAndLabel(TrackBar _trackBar, Label _label, int defaultValue = 0)
        {
            TrackBar = _trackBar;
            DefaultValue = defaultValue;

            TrackBar.Minimum = MinValue;
            TrackBar.Maximum = MaxValue;
            TrackBar.TickStyle = ShowTicks ? TickStyle.Both : TickStyle.None;
            TrackBar.TickFrequency = MaxValue / 10;

            TrackBar.SmallChange = 1;
            TrackBar.LargeChange = MaxValue / 200;

            Label = _label;
            SetValue(defaultValue);

            TrackBar.ValueChanged += (_, __) => { _label.Text = _trackBar.Value.ToString(); };
        }

        public readonly void SetValue(int value)
        {
            int normalizedvalue = value <= MaxValue ? value >= MinValue ? value : MinValue : MaxValue;
            TrackBar.Value = normalizedvalue;
            Label.Text = normalizedvalue.ToString();
        }

        public readonly void Reset() => SetValue(DefaultValue);
    }
}
