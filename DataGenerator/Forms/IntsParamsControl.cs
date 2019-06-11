using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Project.DataGenerator.Misc;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class IntsParamsControl : UserControl
	{
		public IntegersGen GetGen() => new IntegersGen((int)numericUpDownMin.Value, (int)numericUpDownMax.Value);



		public IntsParamsControl()
		{
			InitializeComponent();

			numericUpDownMin.NumericsUpdate(-1000000, 1000000, 1);
			numericUpDownMax.NumericsUpdate(-1000000, 1000000, 100);
		}
	}
}
