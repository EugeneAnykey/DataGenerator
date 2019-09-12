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
		FileGen fileGen = new FileGen();
		Stopwatch watch = new Stopwatch();


		Colorer colorer = new Colorer();

		// init
		public DataGenForm()
		{
			InitializeComponent();

			Text = Application.ProductName;

			rowsCountControl1.BackColor =
				columnsEditControl1.BackColor =
				colorer[13];

			saveFileDialog1.Filter = "Text file (*.txt)|*.txt";

			rowsCountControl1.GenerateFile += (_, __) => GenerateBaseGenFile(ChooseFilename());
			menuFileGenerate.Click += (_, __) => GenerateBaseGenFile(ChooseFilename());
			menuAbout.Click += FormUtils.ShowAbout;
			menuExit.Click += (_, __) => Close();

			menuRecolor.Click += (_,__) => rowsCountControl1.BackColor = columnsEditControl1.BackColor = colorer.Random();
			//menuRecolor.Visible = false;
		}



		// private: ShowElapsed.
		void ShowElapsed()
		{
			const string mesDone = "Done by: {0}";
			toolStripLabelStatus.Text = string.Format(mesDone, watch.Elapsed);

			if (toolStripProgressBar.Visible)
			{
				toolStripProgressBar.Value = 0;
				toolStripProgressBar.Visible = false;
			}
		}

		void ShowElapsed(float percents)
		{
			const string mesElapsed = "Elapsed: {0}";
			toolStripLabelStatus.Text = string.Format(mesElapsed, watch.Elapsed);

			if (!toolStripProgressBar.Visible)
			{
				toolStripProgressBar.Visible = true;
			}
			toolStripProgressBar.Value = (int)(100 * percents);
		}



		// private: ChooseFilename
		string ChooseFilename()
		{
			const string mesText = "Could not generate a file without columns.";
			const string mesCap = "No columns";
			const string filenameMask = "random_r{0}_c{1}.txt";

			var cols = columnsEditControl1.GetBaseGens().Length;

			if (cols == 0)
			{
				MessageBox.Show(mesText, mesCap, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return null;
			}

			saveFileDialog1.FileName = string.Format(filenameMask, rowsCountControl1.RowsCountShort, cols);

			return DialogResult.OK == saveFileDialog1.ShowDialog() ? saveFileDialog1.FileName : string.Empty;
		}



		// private: GenerateBaseGenFile
		async void GenerateBaseGenFile(string filename)
		{
			if (string.IsNullOrEmpty(filename))
				return;

			var rows = rowsCountControl1.RowsCount;
			var gens = columnsEditControl1.GetBaseGens();
			var cols = gens.Length;

			watch.Restart();

			var progress = new Progress<float>(v => ShowElapsed(v));

			await Task.Run(() => fileGen.GenerateBaseGenFile(filename, rows, gens, progress));

			watch.Stop();
			ShowElapsed();
		}
	}
}
