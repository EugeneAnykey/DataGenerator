using System;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class DoublesGen : BaseGen, IGen<double>, IStringOutputer
	{
		// field
		public int Min { get; }
		public int Max { get; }
		public int Decimals { get; }

		readonly double divisor;

		public override string Name { get; set; } = "Doubles Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public DoublesGen(int min, int max, int decimals)
		{
			Min = min;
			Max = max;
			Decimals = decimals;
			divisor = Math.Pow(10, decimals);
		}



		// Generate
		public double Generate() => R.Next(Min, Max) / divisor;

		public IEnumerable<double> Generate(int count) => Fill<double>(count, () => R.Next(Min, Max));



		// Output
		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => (R.Next(Min, Max) / divisor).ToString())) as string[];
	}
}
