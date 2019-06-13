using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class DoublesParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// IGenGetter
		public BaseGen GetBaseGen() => new DoublesGen((int)numericUpDownMin.Value, (int)numericUpDownMax.Value, (int)numericUpDownDecimals.Value);

		// IGenRandomGetter
		public BaseGen GetRandomBaseGen()
		{
			string[] rndNames = new[] { "Double", "Value", "Portion", "Float" };
			var min = Randomizer.R.Next(-100, 100);
			var max = min + Randomizer.R.Next(100);
			return new DoublesGen(min, max, Randomizer.R.Next(3)) { Name = Randomizer.OneOf(rndNames) };
		}

		// IGenSetter
		public void SetBaseGen(BaseGen gen)
		{
			if (gen is DoublesGen gen1)
			{
				numericUpDownMin.Value = gen1.Min;
				numericUpDownMax.Value = gen1.Max;
				numericUpDownDecimals.Value = gen1.Decimals;
			}
		}



		public DoublesParamsControl()
		{
			InitializeComponent();

			numericUpDownMin.NumericsUpdate(-1000000, 1000000, 1);
			numericUpDownMax.NumericsUpdate(-1000000, 1000000, 100);
			numericUpDownDecimals.NumericsUpdate(0, 10, 1);
		}
	}
}
