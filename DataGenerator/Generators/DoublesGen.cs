using System;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class DoublesGen : BaseGen, IGen<double>, IStringOutputer
	{
		// field
		readonly int min;
		readonly int max;
		readonly double divisor;

		public override string Name { get; set; } = "Doubles Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public DoublesGen(int min, int max, int decimals)
		{
			this.min = min;
			this.max = max;
			this.divisor = Math.Pow(10, decimals);
		}



		// Generate
		public double Generate() => R.Next(min, max) / divisor;

		public IEnumerable<double> Generate(int count) => Fill<double>(count, () => R.Next(min, max));



		// Output
		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => (R.Next(min, max) / divisor).ToString())) as string[];
	}
}
