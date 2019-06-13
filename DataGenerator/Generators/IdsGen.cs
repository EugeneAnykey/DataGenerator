using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class IdsGen : BaseGen, IGen<int>, IStringOutputer
	{
		// field
		int current;
		public int Start { get; }
		public int Step { get; }

		public override string Name { get; set; } = "Ids Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public IdsGen(int start, int step = 1)
		{
			Start = start;
			Step = step;
			current = start - step;
		}



		// Generate
		public int Generate() => current += Step;

		public IEnumerable<int> Generate(int count) => Fill(count, () => current += Step);



		// Output
		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = Fill(count, () => (current += Step).ToString()) as string[];
	}
}
