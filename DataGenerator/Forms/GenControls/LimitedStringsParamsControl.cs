using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	public partial class LimitedStringsParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// IGenGetter
		public BaseGen GetBaseGen() => useLimitedStrings ? (BaseGen)new LimitedStringsGen(Separate(), 5) : new StringsGen(Separate());

		// IGenRandomGetter
		public BaseGen GetRandomBaseGen()
		{
			string[] Names = new[] { "Colors", "Latin", "Words", "LongWords", "Particles" };
			string[][] lines = new[] {
				LinesHolder.Colors,
				LinesHolder.AlphabetLatin,
				LinesHolder.EngWords,
				LinesHolder.LongEngWords,
				LinesHolder.EngParticles
			};

			var limited = Randomizer.R.Next(1) > 0.5;
			var linesId = Randomizer.R.Next(lines.Length);

			BaseGen gen = limited ? (BaseGen)new LimitedStringsGen(lines[linesId], 5) : new StringsGen(lines[linesId]);
			gen.Name = Names[linesId];

			return gen;
		}

		// IGenSetter
		public void SetBaseGen(BaseGen gen)
		{
			if (gen is LimitedStringsGen gen1)
			{
				numericUpDownFixed.Value = gen1.MaxLength;
				comboBoxItemsSeparator.SelectedItem = commaSeparator;
				textBoxItems.Text = string.Join(commaSeparator.Separators?[0].ToString(), gen1.Lines);
			}

			if (gen is StringsGen gen2)
			{
				comboBoxItemsSeparator.SelectedItem = commaSeparator;
				textBoxItems.Text = string.Join(commaSeparator.Separators?[0].ToString(), gen2.Lines);
			}
		}



		// const
		static readonly SeparatorItem commaSeparator = new SeparatorItem("Comma — [,]", ',');
		static readonly SeparatorItem spaceSeparator = new SeparatorItem("Space — [ ]", ' ');
		static readonly SeparatorItem defaultSeparator = spaceSeparator;



		// field
		SeparatorItem[] separators;

		bool useLimitedStrings;
		public bool UseLimitedStrings
		{
			get => useLimitedStrings;
			set
			{
				useLimitedStrings = value;
				panelMaxLength.Enabled = value;
				panelMaxLength.Visible = value;
			}
		}



		// init
		public LimitedStringsParamsControl()
		{
			InitializeComponent();

			separators = new[]{
				spaceSeparator,
				commaSeparator,
				new SeparatorItem("Period — [.]", '.'),
				new SeparatorItem("Colon — [:]", ':'),
				new SeparatorItem("Semicolon — [;]", ';'),
				new SeparatorItem("New line — [\n]", '\n'),
				new SeparatorItem("Tab — [\t]", '\t'),
				new SeparatorItem("Vertical bar — [|]", '|'),
			};

			listBoxPreview.Dock = DockStyle.Fill;
			listBoxPreview.Visible = false;

			comboBoxItemsSeparator.Items.Clear();
			comboBoxItemsSeparator.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxItemsSeparator.Items.AddRange(separators);

			numericUpDownFixed.NumericsUpdate(0, 100, 5);

			buttonFastExample.Click += (_, __) => FastExample();
			groupBoxItems.Click += (_, __) => TogglePreview();
		}



		// private: Preview
		bool showPreview = false;
		void TogglePreview() => TogglePreview(showPreview = !showPreview);

		void TogglePreview(bool show)
		{
			listBoxPreview.Visible = show;
			textBoxItems.Visible = !show;
			groupBoxItems.Text = show ? "Preview Items:" : "Items:";

			if (show)
			{
				listBoxPreview.Items.Clear();
				listBoxPreview.Items.AddRange(Separate());
			}
		}



		// private: Separate
		string[] Separate()
		{
			var sep = (comboBoxItemsSeparator.SelectedItem as SeparatorItem) ?? defaultSeparator;

			return textBoxItems.Text.Split(sep.Separators);
		}



		// private: FastExample
		void FastExample()
		{
			comboBoxItemsSeparator.SelectedItem = commaSeparator;
			var sep = (comboBoxItemsSeparator.SelectedItem as SeparatorItem) ?? commaSeparator;

			var example = new[] { "a", "bc", "def", "uvwx" };

			textBoxItems.Text = string.Join(sep.Separators[0].ToString(), example);
		}
	}
}
