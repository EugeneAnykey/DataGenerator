using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class CenteredForm : Form
	{
		public CenteredForm()
		{
			InitializeComponent();

			Text = "Data Generator Menu ( . Y . )";

			buttonOpenColumnGeneratorForm.Click += (_,__) => new Forms.ColumnGeneratorForm().ShowDialog();
			buttonOpenDataGenForm.Click += (_, __) => new Forms.DataGenForm().ShowDialog();

			menuExit.Click += (_, __) => Close();
			menuFormsColumnGenerator.Click += (_, __) => new Forms.ColumnGeneratorForm().ShowDialog();
			menuFormsDataGen.Click += (_, __) => new Forms.DataGenForm().ShowDialog();
			menuAbout.Click += Misc.FormUtils.ShowAbout;
		}
	}
}
