using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	public partial class MaskedIdsParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// field
		readonly ToolTip toolTip = new ToolTip();

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
				textBoxMask.Text = gen1.Mask;
		}

		// init
		public MaskedIdsParamsControl()
		{
			InitializeComponent();

			textBoxMask.Text = "#$%^";

			buttonHelp.Click += (_, __) => ShowHelp();

			// tool tips
			toolTip.AutoPopDelay = 5000;
			toolTip.InitialDelay = 1000;
			toolTip.ReshowDelay = 500;
			toolTip.SetToolTip(this.buttonHelp, GetHelp());
		}

		// Help
		string GetHelp() {
			string[] S_MaskedHelp_Txt_Lines = new[] {
				"Use chars for replacements:",
				"",
				"# — for numbers;",
				"$ — for latin letters only;",
				"% — for russian letters only;",
				"^ — for only similar russian and latin letters.",
			};
			return string.Join("\n", S_MaskedHelp_Txt_Lines);
		}

		void ShowHelp()
		{
			const string S_MaskedHelp_Cap = "Replacement info";

			MessageBox.Show(
				GetHelp(),
				S_MaskedHelp_Cap,
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}
	}
}
