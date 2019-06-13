using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class LimitedStringsGen : BaseGen, IGen<string>, IStringOutputer
	{
		// field
		public string[] Lines { get; }
		public int MaxLength { get; }
		readonly int max;

		public override string Name { get; set; } = "Limited Strings Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public LimitedStringsGen(string[] lines, int maxLength)
		{
			Lines = lines;
			MaxLength = maxLength;
			max = lines.Length;
		}



		// private: GetLimited
		string GetLimited(string s) => s.Length <= MaxLength ? s : s.Substring(0, MaxLength);



		// Generate
		public string Generate() => GetLimited(Lines[R.Next(max)]);

		public IEnumerable<string> Generate(int count) => Fill<string>(count, () => GetLimited(Lines[R.Next(max)]));



		// Output
		public string Output() => Generate();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => GetLimited(Lines[R.Next(max)]))) as string[];
	}
}
