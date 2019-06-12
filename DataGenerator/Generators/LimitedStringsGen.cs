using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class LimitedStringsGen : BaseGen, IGen<string>, IStringOutputer
	{
		// field
		readonly string[] lines;
		readonly int maxLength;
		readonly int max;

		public override string Name { get; set; } = "Limited Strings Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public LimitedStringsGen(string[] lines, int maxLength)
		{
			this.lines = lines;
			this.maxLength = maxLength;
			max = lines.Length;
		}



		// private: GetLimited
		string GetLimited(string s) => s.Length <= maxLength ? s : s.Substring(0, maxLength);



		// Generate
		public string Generate() => GetLimited(lines[R.Next(max)]);

		public IEnumerable<string> Generate(int count) => Fill<string>(count, () => GetLimited(lines[R.Next(max)]));



		// Output
		public string Output() => Generate();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => GetLimited(lines[R.Next(max)]))) as string[];
	}
}
