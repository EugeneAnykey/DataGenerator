using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class FixedStringsGen : BaseGen, IGen<string>, IStringOutputer
	{
		// field
		readonly string[] lines;
		readonly int maxLength;
		readonly int max;

		public override string Name { get; set; } = "Fixed Strings Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public FixedStringsGen(string[] lines, int maxLength)
		{
			this.lines = lines;
			this.maxLength = maxLength;
			max = lines.Length;
		}



		// private: GetFixed
		string GetFixed(string s, int maxLength) => s.Length <= maxLength ? s : s.Substring(0, maxLength);

		string GetFixed(string s) => s.Length <= maxLength ? s : s.Substring(0, maxLength);



		// Generate
		public string Generate() => GetFixed(lines[R.Next(max)]);

		public IEnumerable<string> Generate(int count) => Fill<string>(count, () => GetFixed(lines[R.Next(max)]));



		// Output
		public string Output() => Generate();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => GetFixed(lines[R.Next(max)]))) as string[];
	}
}
