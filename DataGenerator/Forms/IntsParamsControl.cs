using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class IntsParamsControl : UserControl, IGenGetter
	{
		public IntegersGen GetGen() => new IntegersGen((int)numericUpDownMin.Value, (int)numericUpDownMax.Value);

		public BaseGen GetBaseGen() => new IntegersGen((int)numericUpDownMin.Value, (int)numericUpDownMax.Value);



		public IntsParamsControl()
		{
			InitializeComponent();

			numericUpDownMin.NumericsUpdate(-1000000, 1000000, 1);
			numericUpDownMax.NumericsUpdate(-1000000, 1000000, 100);
		}
	}
}
