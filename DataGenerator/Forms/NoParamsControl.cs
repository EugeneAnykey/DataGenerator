using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class NoParamsControl : UserControl, IGenGetter
	{
		public NothingGen GetGen() => new NothingGen();

		public BaseGen GetBaseGen() => new NothingGen();



		public NoParamsControl()
		{
			InitializeComponent();
		}
	}
}
