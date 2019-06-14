using System;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class DatesGen : BaseGen, IGen<DateTime>, IStringOutputer
	{
		// field
		public DateTime Min { get; }
		public DateTime Max { get; }

		readonly long dif;

		public override string Name { get; set; } = "Dates Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public DatesGen(DateTime min, DateTime max)
		{
			Min = min;
			Max = max;
			dif = max.Ticks - min.Ticks;
		}



		// Generate
		public DateTime Generate() => new DateTime((long)(R.NextDouble() * dif) + Min.Ticks);

		public IEnumerable<DateTime> Generate(int count) => Fill<DateTime>(count, () => Generate());



		// Output
		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => Generate().ToString())) as string[];
	}
}
