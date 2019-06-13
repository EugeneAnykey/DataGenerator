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
			//buttonGenFile.Click += (_,__) => GenFile(ChooseFilename());
			buttonGenFile.Click += (_, __) => GenFileBaseGen(ChooseFilename());
			buttonTest.Click += (_, __) => GenTestFile("1.txt");
			menuAbout.Click += FormUtils.ShowAbout;
		}
		#endregion



		#region private: GetRowsCount (+Short), ShowElapsed.
		void ShowElapsed() => labelElapsed.Text = $"Elapsed: {watch.Elapsed}.";

		void ShowElapsed(float percents) => labelElapsed.Text = $"Done: {100 * percents:N2}%.\nElapsed: {watch.Elapsed}.";
		#endregion



		#region events handlers
		string ChooseFilename()
		{
			//var cols = (int)numericUpDownColumns.Value;
			var cols = columnsEditControl1.GetBaseGens().Length;
			saveFileDialog1.FileName = $"random_r{rowsCountControl1.RowsCountShort}_c{cols}.txt";

			if (DialogResult.OK != saveFileDialog1.ShowDialog())
			{
				return string.Empty;
			}
			return saveFileDialog1.FileName;
		}
		#endregion



		async void GenFile(string filename)
		{
			var rows = rowsCountControl1.RowsCount;
			var cols = (int)numericUpDownColumns.Value;

			watch.Restart();

			var progress = new Progress<float>(v => ShowElapsed(v));

			string[] types = generator.GenerateTypes(true, cols);

			await Task.Run(() => fileGen.GenerateFile(saveFileDialog1.FileName, rows, types, generator.GetLines, progress));

			watch.Stop();
			ShowElapsed();
		}



		async void GenFileBaseGen(string filename)
		{
			var rows = rowsCountControl1.RowsCount;
			var gens = columnsEditControl1.GetBaseGens();
			var cols = gens.Length;

			watch.Restart();

			var progress = new Progress<float>(v => ShowElapsed(v));

			await Task.Run(() => FileGen.GenerateBaseGenFile(filename, rows, gens, progress));

			watch.Stop();
			ShowElapsed();
		}



		void GenerateRandom()
		{
			//columnsEditControl1.;
		}



		// TEST only
		async void GenTestFile(string filename)
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
				new LimitedStringsGen(LinesHolder.EngWords, 5),
				new StringsGen(LinesHolder.EngWords),
			};

			await Task.Run(() => FileGen.GenerateTestFile(filename, 1000000, gens, progress));

			watch.Stop();
			ShowElapsed();
		}
	}
}
