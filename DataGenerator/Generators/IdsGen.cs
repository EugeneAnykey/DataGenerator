using System;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class IdsGen : IGen<int>
	{
		// field
		int current;
		readonly int step;



		// init
		public IdsGen(int start, int step = 1)
		{
			this.current = start - step;
			this.step = step;
		}



		// Generate
		public int Generate() => current += step;



		public IEnumerable<int> Generate(int count)
		{
			if (count < 0)
				throw new ArgumentException("Should be more than 0");

			var res = new int[count];

			for (int i = 0; i < count; i++)
			{
				res[i] = current += step;
			}

			return res;
		}

	}
}
