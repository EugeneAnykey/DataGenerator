using System;
using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class IntsParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// IGenGetter
		public BaseGen GetBaseGen() => new IntegersGen((int)numericUpDownMin.Value, (int)numericUpDownMax.Value);

		// IGenRandomGetter
		public BaseGen GetRandomBaseGen()
		{
			string[] rndNames = new[] { "Int", "Number", "iVal" };
			var mult = (int)Math.Pow(10, Randomizer.R.Next(2, 4));

			var min = Randomizer.R.Next(-100, 100) * mult;
			var max = min + Randomizer.R.Next(100) * mult;
			return new IntegersGen(min, max) { Name = Randomizer.OneOf(rndNames) };
		}

		// IGenSetter
		public void SetBaseGen(BaseGen gen)
		{
			if (gen is IntegersGen gen1)
			{
				numericUpDownMin.Value = gen1.Min;
				numericUpDownMax.Value = gen1.Max;
			}
		}



		public IntsParamsControl()
		{
			InitializeComponent();

			numericUpDownMin.NumericsUpdate(-1000000, 1000000, 1);
			numericUpDownMax.NumericsUpdate(-1000000, 1000000, 100);
		}
	}
}
