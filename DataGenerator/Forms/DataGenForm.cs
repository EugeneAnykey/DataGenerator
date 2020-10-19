using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using EugeneAnykey.Forms;
using EugeneAnykey.Project.DataGenerator.IO;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class DataGenForm : Form
	{
		#region const
		const string TxtFilter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
		const string XmlFilter = "Xml file (*.xml)|*.xml|All files (*.*)|*.*";
		#endregion

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
				colorer[21];

			saveFileDialog1.Filter = "Text file (*.txt)|*.txt";

			rowsCountControl1.GenerateFile += (_, __) => GenerateBaseGenFile();
			menuFileGenerate.Click += (_, __) => GenerateBaseGenFile();
			menuFileOpen.Click += (_,__) => OpenScheme();
			menuFileSave.Click += (_, __) => SaveScheme();
			menuAbout.Click += FormUtils.ShowAbout;
			menuExit.Click += (_, __) => Close();

			menuRecolor.Click += (_,__) => rowsCountControl1.BackColor = columnsEditControl1.BackColor = colorer.GetRandom();

			// undone!
			toolStripMenuItem1.Visible = 
			menuFileOpen.Visible = menuFileSave.Visible =
			menuFileOpen.Enabled = menuFileSave.Enabled = true;
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
		string ChooseFilename(string messageText, string messageCaption, string filenameMask)
		{
			var cols = columnsEditControl1.GetBaseGens().Length;
			
			if (cols == 0)
			{
				MessageBox.Show(messageText, messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return null;
			}

			saveFileDialog1.FileName = string.Format(filenameMask, cols, rowsCountControl1.RowsCountShort);

			return DialogResult.OK == saveFileDialog1.ShowDialog() ? saveFileDialog1.FileName : string.Empty;
		}



		// private: GenerateBaseGenFile
		const string mesText_Generate = "Could not generate a file without columns.";
		const string mesCap_Generate = "No columns";
		const string filenameMask_Generate = "random_c{0}_r{1}.txt";

		const string mesText_SchemeSave = "Could not save a scheme without columns.";
		const string mesCap_SchemeSave = "No columns";
		const string filenameMask_SchemeSave = "scheme_c{0}.xml";

		void GenerateBaseGenFile()
		{
			saveFileDialog1.Filter = TxtFilter;
			GenerateBaseGenFile(ChooseFilename(mesText_Generate, mesCap_Generate, filenameMask_Generate));
		}

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

		void SaveScheme()
		{
			saveFileDialog1.Filter = XmlFilter;
			var filename = ChooseFilename(mesText_SchemeSave, mesCap_SchemeSave, filenameMask_SchemeSave);

			// save scheme:
			GeneratorsScheme.Save(filename, columnsEditControl1.GetBaseGens());
		}

		void OpenScheme()
		{
			openFileDialog1.Filter = XmlFilter;
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				var filename = openFileDialog1.FileName;
				// open scheme...
				var list = GeneratorsScheme.Load(filename);
				columnsEditControl1.SetBaseGens(list);
			}

			//throw new NotImplementedException();
		}
	}
}
