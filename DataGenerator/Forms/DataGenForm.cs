using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class DataGenForm : Form
	{
		// field
		//DataGen gen = new DataGen();
		DataGenNew gen = new DataGenNew();
		FileGen fileGen = new FileGen();
		Stopwatch watch = new Stopwatch();



		#region init
		public DataGenForm()
		{
			InitializeComponent();
			
			Text = "Data Generator ( . Y . )";

			Init();
			InitEvent();
		}

		void Init()
		{
			saveFileDialog1.Filter = "Text file (*.txt)|*.txt";
			labelElapsed.Text = $"Elapsed: n/a.";

			comboBoxRowsMult.Items.Clear();
			comboBoxRowsMult.Items.AddRange(new[] { "", "k", "M" });
			comboBoxRowsMult.SelectedIndex = 1;

			numericUpDownRows.Minimum = 1;
			numericUpDownRows.Maximum = 999;
			numericUpDownRows.Value = 100;

			numericUpDownColumns.Minimum = 1;
			numericUpDownColumns.Maximum = 999;
			numericUpDownColumns.Value = 20;
		}

		private void InitEvent()
		{
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

		string GetRowsCountShort() => $"{(int)numericUpDownRows.Value}{comboBoxRowsMult.Text}";
		
		void ShowElapsed() => labelElapsed.Text = $"Elapsed: {watch.Elapsed}.";
		
		void ShowElapsed(float percents) => labelElapsed.Text = $"Done: {100 * percents:N2}%.\nElapsed: {watch.Elapsed}.";
		#endregion



		#region events handlers
		private async void ButtonGenFile_Click(object sender, EventArgs e)
		{
			var rows = GetRowsCount();
			var cols = (int)numericUpDownColumns.Value;

			saveFileDialog1.FileName = $"random_r{GetRowsCountShort()}_c{cols}.txt";

			var filename = string.Empty;
			if (DialogResult.OK != saveFileDialog1.ShowDialog())
			{
				return;
			}

			watch.Start();

			string[] types = gen.GenerateTypes(true, cols);

			var progress = new Progress<float>( v => ShowElapsed(v) );

			await Task.Run(() => DoWork(filename, rows, types, progress));

			watch.Stop();
			ShowElapsed();
		}

		public void DoWork(string filename, int rows, string[] types, IProgress<float> progress)
		{
			fileGen.GenerateFile(saveFileDialog1.FileName, rows, types, gen.GetLines, progress);
		}
		#endregion
	}
}
