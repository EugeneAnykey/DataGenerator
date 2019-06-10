using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Misc;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class DoublesParamsControl : UserControl
	{
		public DoublesParamsControl()
		{
			InitializeComponent();

			numericUpDownMin.NumericsUpdate(-1000000, 1000000, 1);
			numericUpDownMax.NumericsUpdate(-1000000, 1000000, 100);
			numericUpDownDecimals.NumericsUpdate(0, 10, 1);
		}
	}
}
