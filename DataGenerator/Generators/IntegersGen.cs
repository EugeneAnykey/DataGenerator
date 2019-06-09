using System;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class IntegersGen : IGen<int>
	{
		// field
		readonly int min;
		readonly int max;



		// init
		public IntegersGen(int min, int max)
		{
			this.min = min;
			this.max = max;
		}



		// Generate
		public int Generate() => Randomizer.R.Next(min, max);



		public IEnumerable<int> Generate(int count)
		{
			if (count < 0)
				throw new ArgumentException("Should be more than 0");

			var res = new int[count];

			for (int i = 0; i < count; i++)
			{
				res[i] = Randomizer.R.Next(min, max);
			}

			return res;
		}

	}
}
