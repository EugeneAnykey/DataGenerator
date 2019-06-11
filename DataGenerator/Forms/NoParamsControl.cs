using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Project.DataGenerator.Misc;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class NoParamsControl : UserControl
	{
		public NothingGen GetGen() => new NothingGen();



		public NoParamsControl()
		{
			InitializeComponent();
		}
	}
}
