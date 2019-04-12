using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator
{
	public partial class DataGenForm : Form
	{
		#region field
		DataGen gen = new DataGen();
		Stopwatch watch = new Stopwatch();
		#endregion

		#region init
		public DataGenForm()
		{
			InitializeComponent();
			Text = Application.ProductName;

			Init();
		}

		void Init()
		{
			saveFileDialog1.Filter = "Text file (*.txt)|*.txt";
			labelElapsed.Text = $"Elapsed: n/a.";

			comboBoxRowsMult.Items.Clear();
			comboBoxRowsMult.Items.AddRange(new[] { "", "k", "M" });

			numericUpDownRows.Minimum = 1;
			numericUpDownRows.Maximum = 999;
			numericUpDownRows.Value = 100;

			numericUpDownColumns.Minimum = 1;
			numericUpDownColumns.Maximum = 999;
			numericUpDownColumns.Value = 20;
		}
		#endregion

		#region private: GetRowsCount (+Short), ShowElapsed.
		int GetRowsCount()
		{
			var rows = (int)numericUpDownRows.Value;
			if (comboBoxRowsMult.Text == "k")
				rows *= (int)1e3;
			else
			if (comboBoxRowsMult.Text == "M")
				rows *= (int)1e6;

			return rows;
		}

		string GetRowsCountShort()
		{
			return $"{(int)numericUpDownRows.Value}{comboBoxRowsMult.Text}";
		}

		void ShowElapsed()
		{
			labelElapsed.Text = $"Elapsed: {watch.Elapsed}.";
		}
		#endregion

		#region events handlers
		private void buttonGenFile_Click(object sender, EventArgs e)
		{
			var rows = GetRowsCount();
			var cols = (int)numericUpDownColumns.Value;

			saveFileDialog1.FileName = $"a_r{GetRowsCountShort()}_c{cols}.txt";

			var filename = string.Empty;
			if (DialogResult.OK != saveFileDialog1.ShowDialog())
			{
				return;
			}

			watch.Start();

			string[] types = gen.GenerateTypes(true, cols);
			gen.GenerateFile(saveFileDialog1.FileName, rows, types);

			watch.Stop();
			ShowElapsed();
		}
		#endregion
	}
}
