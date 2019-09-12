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

			buttonHelp.Click += (_, __) => ShowHelp();
		}



		void ShowHelp()
		{
			const string S_MaskedHelp_Cap = "Replacement info";

			string[] S_MaskedHelp_Txt_Lines = new[] {
				"Use chars for replacements:",
				"",
				"# — for numbers;",
				"$ — for latin letters only;",
				"% — for russian letters only;",
				"^ — for only similar russian and latin letters.",
			};

			MessageBox.Show(
				string.Join("\n", S_MaskedHelp_Txt_Lines),
				S_MaskedHelp_Cap,
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}
	}
}
