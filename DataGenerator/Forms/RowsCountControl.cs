using System;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class RowsCountControl : UserControl
	{
		// const
		readonly double[] mults = new[] { 1, 1e3, 1e6 };
		readonly string[] multsNames = new[] { "", "k", "M" };



		// events
		public event EventHandler GenerateFile;
		void OnGenerateFile() => GenerateFile?.Invoke(this, EventArgs.Empty);



		// field
		public int RowsCount { get; private set; }
		public string RowsCountShort => GetRowsCountShort();



		// init
		public RowsCountControl()
		{
			InitializeComponent();

			comboBoxRowsMult.Items.Clear();
			comboBoxRowsMult.Items.AddRange(multsNames);
			comboBoxRowsMult.SelectedIndex = 1;

			numericUpDownRows.Minimum = 1;
			numericUpDownRows.Maximum = 999;
			numericUpDownRows.Value = 100;

			numericUpDownRows.ValueChanged += (_, __) => CalcRowsCount();
			comboBoxRowsMult.SelectedIndexChanged += (_, __) => CalcRowsCount();
			buttonGenFile.Click += (_, __) => OnGenerateFile();

			CalcRowsCount();
		}



		void CalcRowsCount() => RowsCount = ((int)numericUpDownRows.Value * (int)mults[comboBoxRowsMult.SelectedIndex]);

		string GetRowsCountShort() => $"{(int)numericUpDownRows.Value}{comboBoxRowsMult.Text}";
	}
}
