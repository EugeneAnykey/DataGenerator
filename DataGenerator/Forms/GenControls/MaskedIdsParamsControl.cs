using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	public partial class MaskedIdsParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// IGenGetter
		public BaseGen GetBaseGen() => new MaskedIdsGen(textBoxMask.Text);

		// IGenRandomGetter
		public BaseGen GetRandomBaseGen()
		{
			string[] rndNames = new[] { "Identification", "Id Number", "Code", "Part Number" };
			string[] maskes = new[] { "#### ######", "^###^^ ##", "$$## $##$###", "%-## %%-###", "$$$ ## - %%%" };

			return new MaskedIdsGen(Randomizer.OneOf(maskes)) { Name = Randomizer.OneOf(rndNames) };
		}

		// IGenSetter
		public void SetBaseGen(BaseGen gen)
		{
			if (gen is MaskedIdsGen gen1)
			{
				textBoxMask.Text = gen1.Mask;
			}
		}



		public MaskedIdsParamsControl()
		{
			InitializeComponent();

			textBoxMask.Text = "";
		}
	}
}
