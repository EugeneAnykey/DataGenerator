using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class ConstantStringsGen : BaseGen, IGen<string>, IStringOutputer
	{
		// field
		public string Constant { get; }

		public override string Name { get; set; } = "Constant String Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public ConstantStringsGen(string constant)
		{
			Constant = constant;
		}



		// Generate
		public string Generate() => Constant;

		public IEnumerable<string> Generate(int count) => Fill(count, () => Constant);



		// Output
		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = Fill(count, () => Constant) as string[];
	}
}
