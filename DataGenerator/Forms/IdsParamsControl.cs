using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Project.DataGenerator.Misc;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class IdsParamsControl : UserControl
	{
		public IdsGen GetGen() => new IdsGen((int)numericUpDownStart.Value, (int)numericUpDownStep.Value);



		public IdsParamsControl()
		{
			InitializeComponent();

			numericUpDownStart.NumericsUpdate(-1000000, 1000000, 1);
			numericUpDownStep.NumericsUpdate(-1000, 1000, 1);
		}
	}
}
