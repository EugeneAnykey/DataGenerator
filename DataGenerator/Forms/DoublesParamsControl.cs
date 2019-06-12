using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class DoublesParamsControl : UserControl, IGenGetter
	{
		public DoublesGen GetGen() => new DoublesGen((int)numericUpDownMin.Value, (int)numericUpDownMax.Value, (int)numericUpDownDecimals.Value);

		public BaseGen GetBaseGen() => new DoublesGen((int)numericUpDownMin.Value, (int)numericUpDownMax.Value, (int)numericUpDownDecimals.Value);



		public DoublesParamsControl()
		{
			InitializeComponent();

			numericUpDownMin.NumericsUpdate(-1000000, 1000000, 1);
			numericUpDownMax.NumericsUpdate(-1000000, 1000000, 100);
			numericUpDownDecimals.NumericsUpdate(0, 10, 1);
		}
	}
}
