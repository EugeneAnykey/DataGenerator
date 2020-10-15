using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Forms;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	public partial class RndSymbolsParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// IGenGetter
		public BaseGen GetBaseGen() => new RndSymbolsGen(GetLines(), (int)numericUpDownLengthMin.Value, (int)numericUpDownLengthMax.Value);

		string[] GetLines() {
			var res = new List<string>();
			foreach (var item in listBoxDefaultSymbols.SelectedItems)
			{
				if (item is string s)
					res.Add(s);
			}
			res.Add(textBoxAdditionalSymbols.Text);
			
			return res.ToArray();
		}

		// IGenRandomGetter
		public BaseGen GetRandomBaseGen()
		{
			string[] Names = new[] { "Code", "Ext code", "Code extended" };
			string[] lines = new[] {
				predefDigits,
				predefLatinUpper,
				predefLatinLower,
				//predefRusUpper,
				//predefRusLower,
			};

			var linesId = Randomizer.R.Next(lines.Length);

			return new RndSymbolsGen(lines, 0, 50) { Name = Names[linesId] };
		}

		// IGenSetter
		public void SetBaseGen(BaseGen gen)
		{
			if (gen is RndSymbolsGen g)
			{
				textBoxAdditionalSymbols.Text = g.AdditionalSymbols;
				numericUpDownLengthMax.Value = g.MaxLength;
				numericUpDownLengthMin.Value = g.MinLength;
			}
		}



		// const
		const int MaxStringLength = 65000;

		const string predefDigits = "0123456789";
		const string predefLatinUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		const string predefRusUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЪЫЭЮЯ";
		readonly string predefLatinLower = predefLatinUpper.ToLower();
		readonly string predefRusLower = predefRusUpper.ToLower();

		// init
		public RndSymbolsParamsControl()
		{
			InitializeComponent();

			string[] lines = new[] {
				predefDigits,
				predefLatinUpper,
				predefLatinLower,
				predefRusUpper,
				predefRusLower,
			};

			listBoxDefaultSymbols.Items.AddRange(lines);
			listBoxDefaultSymbols.SelectedIndex = 0;

			numericUpDownLengthMin.NumericsUpdate(0, 100, 5);
			numericUpDownLengthMax.NumericsUpdate(0, MaxStringLength, 50);

			new Exampler(labelExample, GetBaseGen);
		}
	}
}
