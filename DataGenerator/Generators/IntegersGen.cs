using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class IntegersGen : BaseGen, IGen<int>, IStringOutputer
	{
		// field
		public int Min { get; }
		public int Max { get; }

		public override string Name { get; set; } = "Integers Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public IntegersGen(int min, int max)
		{
			Min = min;
			Max = max;
		}



		// Generate
		public int Generate() => R.Next(Min, Max);

		public IEnumerable<int> Generate(int count) => Fill<int>(count, () => Generate());



		// Output
		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => Generate().ToString())) as string[];
	}
}
