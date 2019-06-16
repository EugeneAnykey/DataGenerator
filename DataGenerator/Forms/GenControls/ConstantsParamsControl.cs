using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	public partial class ConstantsParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// IGenGetter
		public BaseGen GetBaseGen() => new ConstantStringsGen(textBoxConstant.Text);

		// IGenRandomGetter
		public BaseGen GetRandomBaseGen()
		{
			string[] rndNames = new[] { "Constant", "Const", "Default", "Unchangeable" };
			string[] someVals = new[] { "the only", "one", "only this", "this one" };

			return new ConstantStringsGen(Randomizer.OneOf(someVals)) { Name = Randomizer.OneOf(rndNames) };
		}

		// IGenSetter
		public void SetBaseGen(BaseGen gen)
		{
			if (gen is ConstantStringsGen gen1)
			{
				textBoxConstant.Text = gen1.Constant;
			}
		}



		public ConstantsParamsControl()
		{
			InitializeComponent();

			textBoxConstant.Text = "";
		}
	}
}
