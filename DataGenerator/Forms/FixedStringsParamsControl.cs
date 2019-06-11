using System.Collections.Generic;
using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Project.DataGenerator.Misc;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class FixedStringsParamsControl : UserControl
	{
		public StringsGen GetGen() => new StringsGen(Separate());

		public FixedStringsGen GetFixedGen() => new FixedStringsGen(Separate(), (int)numericUpDownFixed.Value);

		public BaseGen GetGenBase()
		{
			if (useFixedStrings)
				return new FixedStringsGen(Separate(), (int)numericUpDownFixed.Value);
			else
				return new StringsGen(Separate());
		}

		// const
		static readonly SeparatorItem commaSeparator = new SeparatorItem("Comma — [,]", ',');
		static readonly SeparatorItem spaceSeparator = new SeparatorItem("Space — [ ]", ' ');
		static readonly SeparatorItem defaultSeparator = spaceSeparator;



		// field
		SeparatorItem[] separators;

		bool useFixedStrings;
		public bool UseFixedStrings
		{
			get => useFixedStrings;
			set
			{
				useFixedStrings = value;
				panelMaxLength.Enabled = value;
				panelMaxLength.Visible = value;
				labelName.Text = value ? "Fixed Strings Parameters" : "Strings Parameters";
			}
		}



		// init
		public FixedStringsParamsControl()
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

			comboBoxItemsSeparator.Items.Clear();
			comboBoxItemsSeparator.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxItemsSeparator.Items.AddRange(separators);

			numericUpDownFixed.NumericsUpdate(0, 100, 5);

			buttonFastExample.Click += (_, __) => FastExample();
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
