using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class IntegersGen : BaseGen, IGen<int>, IStringOutputer
	{
		// field
		readonly int min;
		readonly int max;

		public override string Name { get; set; } = "Integers Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public IntegersGen(int min, int max)
		{
			this.min = min;
			this.max = max;
		}



		// Generate
		public int Generate() => R.Next(min, max);

		public IEnumerable<int> Generate(int count) => Fill<int>(count, () => R.Next(min, max));



		// Output
		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => R.Next(min, max).ToString())) as string[];
	}
}
