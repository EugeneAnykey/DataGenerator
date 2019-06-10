using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class StringsGen : BaseGen, IGen<string>, IStringOutputer
	{
		// field
		readonly string[] lines;
		readonly int max;

		public override string Name { get; set; } = "Strings Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public StringsGen(string[] lines)
		{
			this.lines = lines;
			max = lines.Length;
		}



		// Generate
		public string Generate() => lines[R.Next(max)];

		public IEnumerable<string> Generate(int count) => Fill<string>(count, () => lines[R.Next(max)]);



		// Output
		public string Output() => Generate();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => lines[R.Next(max)])) as string[];
	}
}
