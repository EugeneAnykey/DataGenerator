using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class NothingGen : BaseGen, IGen<string>, IStringOutputer
	{
		// field
		public override string Name { get; set; } = "Nothing Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public NothingGen() { }



		// Generate
		public string Generate() => string.Empty;

		public IEnumerable<string> Generate(int count) => Fill<string>(count, () => string.Empty);



		// Output
		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = Fill<string>(count, () => string.Empty) as string[];
	}
}
