using System;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class FloatsGen : IGen<double>
	{
		// field
		readonly int min;
		readonly int max;
		readonly double divisor;



		// init
		public FloatsGen() { }

		public FloatsGen(int min, int max, int decimals)
		{
			this.min = min;
			this.max = max;
			this.divisor = Math.Pow(10, decimals);
		}

		public void Set(int min, int max, int decimals)
		{
			
		}



		// Generate
		public double Generate() => Randomizer.R.Next(min, max) / divisor;



		public IEnumerable<double> Generate(int count)
		{
			if (count < 0)
				throw new ArgumentException("Should be more than 0");

			var res = new double[count];

			for (int i = 0; i < count; i++)
			{
				res[i] = Randomizer.R.Next(min, max) / divisor;
			}

			return res;
		}



		// Obsolete Generate
		[Obsolete]
		float GenerateFloat(int max) => Randomizer.R.Next(max) / 100.0f;

		[Obsolete]
		float GenerateFloat(int min, int max, float divisor) => Randomizer.R.Next(min, max) / divisor;
	}
}
