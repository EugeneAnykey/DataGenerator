using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using EugeneAnykey.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class DataGenForm : Form
	{
		// field
		//Generators.DataGeneratorOld gen1 = new Generators.DataGeneratorOld();
		DataGen generator = new DataGen();
		FileGen fileGen = new FileGen();
		Stopwatch watch = new Stopwatch();



		#region init
		public DataGenForm()
		{
			InitializeComponent();
			
			Text = Application.ProductName;

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
			menuExit.Click += (_, __) => Close();
			menuFormsColumnGenerator.Click += (_, __) => new ColumnGeneratorForm().ShowDialog();
			buttonTest.Click += (_, __) => GenTestFile();
			menuAbout.Click += FormUtils.ShowAbout;
		}
		#endregion



		#region private: GetRowsCount (+Short), ShowElapsed.
		void ShowElapsed() => labelElapsed.Text = $"Elapsed: {watch.Elapsed}.";
		
		void ShowElapsed(float percents) => labelElapsed.Text = $"Done: {100 * percents:N2}%.\nElapsed: {watch.Elapsed}.";
		#endregion



		#region events handlers
		void ButtonGenFile_Click(object sender, EventArgs e)
		{
			var rows = rowsCountControl1.RowsCount;
			var cols = (int)numericUpDownColumns.Value;

			saveFileDialog1.FileName = $"random_r{rowsCountControl1.RowsCountShort}_c{cols}.txt";

			if (DialogResult.OK != saveFileDialog1.ShowDialog())
			{
				return;
			}
			var filename = saveFileDialog1.FileName;

			GenFile(filename, cols, rows);
		}



		public void DoWork(string filename, int rows, string[] types, IProgress<float> progress)
		{
			fileGen.GenerateFile(saveFileDialog1.FileName, rows, types, generator.GetLines, progress);
		}
		#endregion



		async void GenFile(string filename, int cols, int rows)
		{
			watch.Restart();

			var progress = new Progress<float>(v => ShowElapsed(v));

			string[] types = generator.GenerateTypes(true, cols);

			await Task.Run(() => DoWork(filename, rows, types, progress));

			watch.Stop();
			ShowElapsed();
		}



		// TEST only
		async void GenTestFile()
		{
			watch.Restart();

			var progress = new Progress<float>(v => ShowElapsed(v));

			var gens = new BaseGen[] {
				new IdsGen(1, 1),
				new IntegersGen(10, 60),
				new DoublesGen(10, 60, 1),
				new DoublesGen(70, 80, 2),
				new IntegersGen(7, 9),
				new IdsGen(18, 3),
				new LimitedStringsGen(WordsHolder.EngWords, 5),
				new StringsGen(WordsHolder.EngWords),
			};

			await Task.Run(() => FileGen.GenerateTestFile("1.txt", 1000000, gens, progress));

			watch.Stop();
			ShowElapsed();
		}
	}
}
