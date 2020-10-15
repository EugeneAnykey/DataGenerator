using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	public partial class StringsParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// IGenGetter
		public BaseGen GetBaseGen() => new StringsGen(Separate(), useLimitedStrings ? (int)numericUpDownFixed.Value : 0);

		readonly string[][] lines = new[] {
			new[] { "a", "bc", "def", "uvwx" },
			LinesHolder.AlphabetLatin1,
			LinesHolder.AlphabetLatin2,
			LinesHolder.AlphabetLatin3,
			LinesHolder.Colors,
			LinesHolder.EngWords,
			LinesHolder.LongEngWords,
			LinesHolder.EngParticles,
		};

		// IGenRandomGetter
		public BaseGen GetRandomBaseGen()
		{
			string[] Names = new[] { "misc", "Latin_1", "Latin_2", "Latin_3", "Colors", "Words", "LongWords", "Particles" };

			var possibleLimit = Randomizer.R.Next(lines.Length - 1);
			var limited = possibleLimit > 2;
			var linesId = Randomizer.R.Next(lines.Length);

			return new StringsGen(lines[linesId], limited ? possibleLimit : 0) { Name = Names[linesId] };
		}

		// IGenSetter
		public void SetBaseGen(BaseGen gen)
		{
			if (gen is StringsGen g)
			{
				numericUpDownFixed.Value = g.StringLengthLimit;
				comboBoxItemsSeparator.SelectedItem = commaSeparator;
				checkBoxLimitedStrings.Checked = g.Limited;
				textBoxItems.Text = string.Join(commaSeparator.Separators?[0].ToString(), g.Lines);
			}

			TogglePreview(showPreview);
		}



		// const
		static readonly SeparatorItem commaSeparator = new SeparatorItem("Comma — [,]", ',');
		static readonly SeparatorItem spaceSeparator = new SeparatorItem("Space — [ ]", ' ');
		static readonly SeparatorItem defaultSeparator = spaceSeparator;

		// field
		readonly SeparatorItem[] separators;

		bool useLimitedStrings;
		public bool UseLimitedStrings
		{
			get => useLimitedStrings;
			set
			{
				useLimitedStrings = value;
				panelMaxLength.Enabled = value;
				panelMaxLength.Visible = value;
				if (!value)
					numericUpDownFixed.Value = 0;
			}
		}

		// init
		public StringsParamsControl()
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
			checkBoxLimitedStrings.CheckedChanged += (_, __) => UseLimitedStrings = checkBoxLimitedStrings.Checked;

			new Exampler(labelExample, GetBaseGen);

			FastExample();
		}

		// private
		bool showPreview = false;
		void TogglePreview() => TogglePreview(showPreview = !showPreview);

		void TogglePreview(bool show)
		{
			listBoxPreview.Visible = show;
			textBoxItems.Visible = !show;

			if (show)
			{
				listBoxPreview.Items.Clear();
				listBoxPreview.Items.AddRange(Separate());
			}

			groupBoxItems.Text = show ? $"Preview Items {listBoxPreview.Items.Count}:" : "Items:";
		}

		string[] Separate()
		{
			var sep = (comboBoxItemsSeparator.SelectedItem as SeparatorItem) ?? defaultSeparator;

			return textBoxItems.Text.Split(sep.Separators);
		}

		void FastExample()
		{
			comboBoxItemsSeparator.SelectedItem = commaSeparator;
			var sep = (comboBoxItemsSeparator.SelectedItem as SeparatorItem) ?? commaSeparator;

			textBoxItems.Text = string.Join(sep.Separators[0].ToString(), Randomizer.OneOf(lines));
		}
	}
}
