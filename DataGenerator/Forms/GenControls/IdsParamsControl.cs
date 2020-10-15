using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	public partial class IdsParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// IGenGetter
		public BaseGen GetBaseGen() => new IdsGen((int)numericUpDownStart.Value, (int)numericUpDownStep.Value);

		// IGenRandomGetter
		public BaseGen GetRandomBaseGen()
		{
			string[] rndNames = new[] { "Id", "Num", "Position", "Pos" };
			var start = Randomizer.R.Next(1, 10000);
			var step = Randomizer.R.Next(10);
			return new IdsGen(start, step) { Name = Randomizer.OneOf(rndNames) };
		}

		// IGenSetter
		public void SetBaseGen(BaseGen gen)
		{
			if (gen is IdsGen g)
			{
				numericUpDownStart.Value = g.Start;
				numericUpDownStep.Value = g.Step;
			}
		}

		// init
		public IdsParamsControl()
		{
			InitializeComponent();

			numericUpDownStart.NumericsUpdate(-1000000, 1000000, 1);
			numericUpDownStep.NumericsUpdate(-1000, 1000, 1);
			
			new Exampler(labelExample, GetBaseGen);
		}
	}
}
