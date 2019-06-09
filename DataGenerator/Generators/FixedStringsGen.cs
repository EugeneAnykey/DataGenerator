using System;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class FixedStringsGen : IGen<string>
	{
		// field
		readonly string[] lines;
		readonly int maxLength;
		readonly int max;



		// init
		public FixedStringsGen(string[] lines, int maxLength)
		{
			this.lines = lines;
			this.maxLength = maxLength;
			max = lines.Length;
		}



		// private: GetFixed
		string GetFixed(string s, int maxLength) => s.Length <= maxLength ? s : s.Substring(0, maxLength);
		
		string GetFixed(string s) => s.Length <= maxLength ? s : s.Substring(0, maxLength);



		// Generate
		public string Generate() => GetFixed(lines[Randomizer.R.Next(max)]);



		public IEnumerable<string> Generate(int count)
		{
			if (count < 0)
				throw new ArgumentException("Should be more than 0");

			var res = new string[count];

			for (int i = 0; i < count; i++)
			{
				res[i] = GetFixed(lines[Randomizer.R.Next(max)]);
			}

			return res;
		}
	}
}
