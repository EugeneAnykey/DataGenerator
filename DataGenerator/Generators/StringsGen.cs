using System;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class StringsGen : IGen<string>
	{
		// field
		readonly string[] lines;
		readonly int maxLength;
		readonly int max;



		// init
		public StringsGen(string[] lines)
		{
			this.lines = lines;
			max = lines.Length;
		}

		public StringsGen(string[] lines, int maxLength)
		{
			this.lines = lines;
			this.maxLength = maxLength;
			max = lines.Length;
		}



		// Generate
		public string Generate() => lines[Randomizer.R.Next(max)];



		public IEnumerable<string> Generate(int count)
		{
			if (count < 0)
				throw new ArgumentException("Should be more than 0");

			var res = new string[count];

			for (int i = 0; i < count; i++)
			{
				res[i] = lines[Randomizer.R.Next(max)];
			}

			return res;
		}
	}
}
