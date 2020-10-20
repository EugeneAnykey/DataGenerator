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

		#region init
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
		}
		#endregion


		#region private: ShowElapsed.
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
		#endregion


		#region private: CheckColumns, ChooseFilename
		bool CheckColumns()
		{
			var cols = columnsEditControl1.GetBaseGens().Length;

			const string messageText = "Could not make file without columns.";
			const string messageCaption = "No columns";

			if (cols == 0)
			{
				MessageBox.Show(messageText, messageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			return true;
		}
		
		string ChooseFilename(string filenameMask)
		{
			var cols = columnsEditControl1.GetBaseGens().Length;
			
			saveFileDialog1.FileName = string.Format(filenameMask, cols, rowsCountControl1.RowsCountShort);

			return DialogResult.OK == saveFileDialog1.ShowDialog() ? saveFileDialog1.FileName : string.Empty;
		}
		#endregion


		#region private: GenerateBaseGenFile
		void GenerateBaseGenFile()
		{
			if (!CheckColumns())
				return;

			saveFileDialog1.Filter = TxtFilter;
			const string filenameMask_Generate = "random_c{0}_r{1}.txt";
			GenerateBaseGenFile(ChooseFilename(filenameMask_Generate));
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
		#endregion


		#region Scheme
		void SaveScheme()
		{
			if (!CheckColumns())
				return;

			saveFileDialog1.Filter = XmlFilter;
			const string filenameMask_SchemeSave = "scheme_c{0}.xml";
			var filename = ChooseFilename(filenameMask_SchemeSave);

			GeneratorsScheme.Save(filename, columnsEditControl1.GetBaseGens());
		}

		void OpenScheme()
		{
			openFileDialog1.Filter = XmlFilter;
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				var filename = openFileDialog1.FileName;
				var list = GeneratorsScheme.Load(filename);
				columnsEditControl1.SetBaseGens(list);
			}
			//throw new NotImplementedException();
		}
		#endregion
	}
}
