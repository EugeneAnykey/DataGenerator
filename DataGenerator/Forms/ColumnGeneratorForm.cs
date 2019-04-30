using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class ColumnGeneratorForm : Form
	{
		// const
		readonly SeparatorItem defaultSeparator = new SeparatorItem("default", ' ');

		// field
		string[] resultLines;
		
		int linesCount = 30;

		SeparatorItem[] separators;
		


		// init
		public ColumnGeneratorForm()
		{
			InitializeComponent();

			separators = new[]{
				new SeparatorItem("Comma — [,]", ',' ),
				new SeparatorItem("Semicolon — [;]", ';' ),
				new SeparatorItem("Space — [ ]", ' ' ),
				new SeparatorItem("Tab — [\t]", '\t' ),
				new SeparatorItem("Vertical bar — [|]", '|' ),
				new SeparatorItem("Period — [.]", '.' ),
				new SeparatorItem("Colon — [:]", ':' ),
			};

			comboBoxItemsSeparator.Items.Clear();
			comboBoxItemsSeparator.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxItemsSeparator.Items.AddRange(separators);

			buttonClose.Click += (_, __) => Close();
			buttonCopyColumns.Click += (_, __) => Copy();
			buttonGenerate.Click += (_, __) => Generate();
		}



		private void Copy()
		{
			Clipboard.SetText(
				string.Join("\r\n", resultLines),
				TextDataFormat.UnicodeText
			);
		}

		

		private void Generate()
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
	}
}
