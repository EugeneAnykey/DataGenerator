using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class StringsGen : BaseGen, IGen<string>, IStringOutputer
	{
		// field
		public string[] Lines { get; }
		readonly int max;

		public override string Name { get; set; } = "Strings Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public StringsGen(string[] lines)
		{
			Lines = lines;
			max = lines.Length;
		}



		// Generate
		public string Generate() => Lines[R.Next(max)];

		public IEnumerable<string> Generate(int count) => Fill<string>(count, () => Lines[R.Next(max)]);



		// Output
		public string Output() => Generate();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => Lines[R.Next(max)])) as string[];
	}
}
