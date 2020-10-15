using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class RndSymbolsGen : BaseGen, IGen<string>, IStringOutputer
	{
		// const
		const int MaxPossibleLength = 65000;
		
		// field
		public int MinLength { get; }
		public int MaxLength { get; }
		//public int AvgLength { get; }

		public string[] Lines { get; set; }
		public string AdditionalSymbols { get; }
		
		public string Line { get; }
		public int SymbolsCount { get; }

		public override string Name { get; set; } = "Random Symbols Gen";
		public string[] Latest { get; private set; } = new string[0];



		// init
		public RndSymbolsGen(string[] lines, int min = 0, int max = 1000)
		{
			MinLength = min > 0 ? min : 0;
			MaxLength = max > 0 ? (max < MaxPossibleLength ? max : MaxPossibleLength) : 0;
			//AvgLength = (min + max) / 2;
			Lines = lines;
			Line = string.Concat(lines);
			SymbolsCount = Line.Length;
			AdditionalSymbols = lines[lines.Length - 1];
		}



		// Generate
		public string Generate()
		{
			if (SymbolsCount == 0)
				return string.Empty;

			var len = R.Next(MinLength, MaxLength + 1);
			var chars = new char[len];
			for (int i = 0; i < len; i++)
			{
				chars[i] = Line[R.Next(SymbolsCount)];
			}
			string res = new string(chars);
			return res;
		}

		public IEnumerable<string> Generate(int count) => Fill(count, () => Generate());

		// Output
		public string Output() => Generate();

		public IEnumerable<string> Output(int count) => Latest = Fill(count, () => Generate()) as string[];
	}
}
