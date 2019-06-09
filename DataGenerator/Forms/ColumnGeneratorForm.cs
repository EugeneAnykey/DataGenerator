using System.Collections.Generic;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class ColumnGeneratorForm : Form
	{
		// const
		static readonly SeparatorItem commaSeparator = new SeparatorItem("Comma — [,]", ',');
		static readonly SeparatorItem spaceSeparator = new SeparatorItem("Space — [ ]", ' ');
		static readonly SeparatorItem defaultSeparator = spaceSeparator;

		// field
		string[] resultLines;

		int linesCount = 30;

		SeparatorItem[] separators;



		// init
		public ColumnGeneratorForm()
		{
			InitializeComponent();

			Text = "Column Generator ( . Y . )";

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

			buttonClose.Click += (_, __) => Close();
			buttonCopyColumns.Click += (_, __) => Copy();
			buttonGenerate.Click += (_, __) => Generate();
			buttonFastExample.Click += (_, __) => FastExample();
		}



		void Copy()
		{
			Clipboard.SetText(
				string.Join("\r\n", resultLines),
				TextDataFormat.UnicodeText
			);
		}



		void Generate()
		{
			var sep = (comboBoxItemsSeparator.SelectedItem as SeparatorItem) ?? defaultSeparator;

			var items = textBoxItems.Text.Split(sep.Separators);

			var lines = new List<string>();

			// local func:
			string GenerateString() => items[Randomizer.R.Next(items.Length)];

			for (int i = 0; i < linesCount; i++)
			{
				lines.Add(GenerateString());
			}

			this.resultLines = lines.ToArray();

			listBoxResultedColumns.Items.Clear();
			listBoxResultedColumns.Items.AddRange(resultLines);
		}



		void FastExample()
		{
			comboBoxItemsSeparator.SelectedItem = commaSeparator;
			var sep = (comboBoxItemsSeparator.SelectedItem as SeparatorItem) ?? commaSeparator;

			var example = new[] { "a", "bc", "def", "uvwx" };

			textBoxItems.Text = string.Join(sep.Separators[0].ToString(), example);
		}
	}
}
