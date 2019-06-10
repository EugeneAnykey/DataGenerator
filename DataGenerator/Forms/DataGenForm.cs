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
		//Generators.DataGeneratorOld gen1 = new Generators.DataGeneratorOld();
		Generators.DataGen generator = new Generators.DataGen();
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

			numericUpDownColumns.Minimum = 1;
			numericUpDownColumns.Maximum = 999;
			numericUpDownColumns.Value = 20;
		}

		private void InitEvent()
		{
			buttonTest.Click += (_, __) => GenTestFile();
		}
		#endregion



		#region private: GetRowsCount (+Short), ShowElapsed.
		void ShowElapsed() => labelElapsed.Text = $"Elapsed: {watch.Elapsed}.";
		
		void ShowElapsed(float percents) => labelElapsed.Text = $"Done: {100 * percents:N2}%.\nElapsed: {watch.Elapsed}.";
		#endregion



		#region events handlers
		async void ButtonGenFile_Click(object sender, EventArgs e)
		{
			var rows = rowsCountControl1.RowsCount;
			var cols = (int)numericUpDownColumns.Value;

			saveFileDialog1.FileName = $"random_r{rowsCountControl1.RowsCountShort}_c{cols}.txt";

			if (DialogResult.OK != saveFileDialog1.ShowDialog())
			{
				return;
			}
			var filename = saveFileDialog1.FileName;

			watch.Restart();

			var progress = new Progress<float>(v => ShowElapsed(v));

			string[] types = generator.GenerateTypes(true, cols);

			await Task.Run(() => DoWork(filename, rows, types, progress));

			watch.Stop();
			ShowElapsed();
		}



		public void DoWork(string filename, int rows, string[] types, IProgress<float> progress)
		{
			fileGen.GenerateFile(saveFileDialog1.FileName, rows, types, generator.GetLines, progress);
		}
		#endregion



		// TEST only
		async void GenTestFile()
		{
			watch.Restart();

			var progress = new Progress<float>(v => ShowElapsed(v));

			await Task.Run(() => FileGen.Test(progress));

			watch.Stop();
			ShowElapsed();
		}
	}
}
