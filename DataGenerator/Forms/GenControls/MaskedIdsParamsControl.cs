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
			string Convert(string alpha) => alpha
				.Replace('D', MaskHolder.PredefMaskDigit)
				.Replace('A', MaskHolder.PredefMaskAutos)
				.Replace('H', MaskHolder.PredefMaskHex)
				.Replace('L', MaskHolder.PredefMaskLatin)
				.Replace('R', MaskHolder.PredefMaskRus);

			string[] rndNames = new[] { "Identification", "Id Number", "Code", "Part Number", "Hash" };
			string[] masks = new[] {
				"DDDD DDDDDD", // rus passport
				"ADDDAA DD", // rus auto
				"LLDD LDDLDDD",
				"R-DD RR-DDD",
				"LLL DD - RRR",
				"HHHHHHHH", // md5
				"HHHHHHHH-HHHH-HHHH-HHHH-HHHHHHHHHHHH", // guid
			};

			return new MaskedIdsGen(Convert(Randomizer.OneOf(masks))) { Name = Randomizer.OneOf(rndNames) };
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

			textBoxMask.Text = $"d={MaskHolder.PredefMaskDigit}, h={MaskHolder.PredefMaskHex}, l={MaskHolder.PredefMaskLatin}, r={MaskHolder.PredefMaskRus}, a={MaskHolder.PredefMaskAutos}";

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
				$"{MaskHolder.PredefMaskDigit} — for numbers;",
				$"{MaskHolder.PredefMaskHex} — for hex numbers;",
				$"{MaskHolder.PredefMaskLatin} — for latin letters only;",
				$"{MaskHolder.PredefMaskRus} — for russian letters only;",
				$"{MaskHolder.PredefMaskAutos} — for only similar russian and latin letters.",
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
