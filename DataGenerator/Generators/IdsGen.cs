using System;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class IdsGen : BaseGen, IGen<int>, IStringOutputer
	{
		// field
		int current;
		readonly int step;

		public override string Name { get; set; } = "Ids Gen";

		public string[] Latest { get; private set; }



		// init
		public IdsGen(int start, int step = 1)
		{
			this.current = start - step;
			this.step = step;
			Latest = new string[0];
		}



		// Generate
		public int Generate() => current += step;

		public IEnumerable<int> Generate(int count) => Fill<int>(count, () => current += step);



		// Output
		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = Fill<string>(count, () => (current += step).ToString()) as string[];
	}
}
