using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class StringsGen : BaseGen, IGen<string>, IStringOutputer
	{
		// field
		public string[] Lines { get; }
		public int StringLengthLimit { get; }
		public bool Limited { get; }
		readonly int linesCount;

		public override string Name { get; set; }

		public string[] Latest { get; private set; } = new string[0];



		// init
		public StringsGen(string[] lines) : this(lines, 0) { }

		public StringsGen(string[] lines, int lengthLimit)
		{
			Lines = lines;
			linesCount = lines.Length;

			StringLengthLimit = lengthLimit > 0 ? lengthLimit : 0;
			Limited = StringLengthLimit > 0;
			Name = Limited ? "Limited Strings Gen" : "Strings Gen";
		}



		// private: GetLimited
		string GetLimited(string s) => s.Length <= StringLengthLimit ? s : s.Substring(0, StringLengthLimit);



		// Generate
		public string Generate() => Limited ? GetLimited(Lines[R.Next(linesCount)]) : Lines[R.Next(linesCount)];

		public IEnumerable<string> Generate(int count) => Fill(count, () => Generate());



		// Output
		public string Output() => Generate();

		public IEnumerable<string> Output(int count) => Latest = Fill(count, () => Generate()) as string[];
	}
}
