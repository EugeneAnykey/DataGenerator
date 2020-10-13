using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	public partial class MaskedIdsParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// field
		readonly Dictionary<string, string> templates = new Dictionary<string, string>();
		readonly Dictionary<string, string> templatesRndNames = new Dictionary<string, string>();
		readonly ToolTip toolTip = new ToolTip();
		readonly string help =
			"Use chars for replacements:\n\n" +
			$"{MaskHolder.PredefMaskDigit} — for numbers;\n" +
			$"{MaskHolder.PredefMaskHex} — for hex numbers;\n" +
			$"{MaskHolder.PredefMaskLatin} — for latin letters only;\n" +
			$"{MaskHolder.PredefMaskRus} — for russian letters only;\n" +
			$"{MaskHolder.PredefMaskAutos} — for letters that are similar in russian and latin."
		;

		// IGenGetter
		public BaseGen GetBaseGen() => new MaskedIdsGen(textBoxMask.Text);

		// IGenRandomGetter
		public BaseGen GetRandomBaseGen()
		{
			var i = Randomizer.R.Next(templates.Count);
			var val = templates.ElementAt(i).Value;
			var name = templatesRndNames.ElementAt(i).Value;
			return new MaskedIdsGen(val) { Name = name };
		}

		// IGenSetter
		public void SetBaseGen(BaseGen gen)
		{
			if (gen is MaskedIdsGen gen1)
			{
				comboBoxTemplates.SelectedIndex = 0;
				textBoxMask.Text = gen1.Mask;
			}
		}

		// init
		public MaskedIdsParamsControl()
		{
			InitializeComponent();

			FillTemplates();

			comboBoxTemplates.DataSource = new BindingSource(templates, null);
			comboBoxTemplates.ValueMember = "Value";
			comboBoxTemplates.DisplayMember = "Key";

			comboBoxTemplates.SelectedIndexChanged += (_, __) => textBoxMask.Text = ((KeyValuePair<string, string>)comboBoxTemplates.SelectedItem).Value;
			comboBoxTemplates.SelectedIndex = 1;

			// tool tips
			toolTip.AutoPopDelay = 10000;
			toolTip.InitialDelay = 1000;
			toolTip.ReshowDelay = 500;
			toolTip.SetToolTip(this.labelHelp, help);
		}

		// private
		struct Templater
		{
			public string Name;
			public string RndName;
			public string Mask;

			public Templater(string name, string rndName, string mask)
			{
				Name = name;
				RndName = rndName;
				Mask = mask;
			}
		};

		void FillTemplates() {
			var values = new Templater[] {
				new Templater("user input", "Empty_Code", ""),
				new Templater("example", "Example_code", $"d=DD, h=HH, l=L, r=R, a=A"),
				new Templater("guid", "GUID", "HHHHHHHH-HHHH-HHHH-HHHH-HHHHHHHHHHHH"),
				new Templater("md5", "MD5", new string('H', 8)),
				new Templater("sha 64", "SHA", new string('H', 64)),
				new Templater("passport (russian code)", "Passport", "DDDD DDDDDD"),
				new Templater("auto (russian code)", "Auto_code", "ADDDAA DD"),
				new Templater("latin + digits", "Identification", "LLDD LDDLDDD"),
				new Templater("rus + digits", "Sample_rus_id", "R-DD RR-DDD"),
				new Templater("latin + rus + digits (1)", "Sample_code", "LLL DD - RRR"),
				new Templater("latin + rus + digits (2)", "Id_number", "LRD DDDDDD"),
			};

			string Convert(string alpha) => alpha
				.Replace('D', MaskHolder.PredefMaskDigit)
				.Replace('A', MaskHolder.PredefMaskAutos)
				.Replace('H', MaskHolder.PredefMaskHex)
				.Replace('L', MaskHolder.PredefMaskLatin)
				.Replace('R', MaskHolder.PredefMaskRus);
			for (int i = 0; i < values.Length; i++)
			{
				templates.Add(values[i].Name, Convert(values[i].Mask));
				templatesRndNames.Add(values[i].Name, values[i].RndName);
			}
		}
	}
}
