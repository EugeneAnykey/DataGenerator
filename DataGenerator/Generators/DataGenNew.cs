using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class DataGenNew
	{
		// const
		const int rowsPortion = 2460;

		const string idName = "id";
		const string strName = "string";
		const string numName = "numeric";
		const string floatName = "float";
		// not used currently:
		const string dateName = "date";
		const string timeName = "time";
		const string dateTimeName = "datetime";



		// field
		IdsGen idsGen;
		FloatsGen floatsGen;
		IntegersGen intsGen;
		FixedStringsGen strsGen;



		// init
		public DataGenNew()
		{
			idsGen = new IdsGen(0, 1);
			floatsGen = new FloatsGen(0, 100000, 2);
			intsGen = new IntegersGen(0, 1000);
			strsGen = new FixedStringsGen(WordsHolder.EngWords, 6);
		}



		// public: gen types
		public string[] GenerateTypes(bool needId, int cols)
		{
			var res = new List<string>();

			if (needId)
				res.Add(idName);

			int start = needId ? 1 : 0;

			for (int i = start; i < cols; i++)
			{
				switch (Randomizer.R.Next(1, 6))
				{
					case 1:
					case 2:
						res.Add(numName);
						break;

					case 3:
					case 4:
						res.Add(strName);
						break;

					case 5:
						res.Add(floatName);
						break;

					default:
						break;
				}
			}
			return res.ToArray();
		}



		// public: gen lines
		public IEnumerable<string> GetLines(int rows, string[] types)
		{
			//var igens = new IGen<object> { idsGen, floatsGen, intsGen, strsGen };

			var res = new List<string>();

			int cols = types.Length;

			res.Add(string.Join("\t", types));

			for (int i = 0; i < rows; i++)
			{
				var ss = new string[cols];
				for (int j = 0; j < cols; j++)
				{
					if (types[j] == idName)
						ss[j] = idsGen.Generate().ToString();
					if (types[j] == numName)
						ss[j] = intsGen.Generate().ToString();
					if (types[j] == floatName)
						ss[j] = floatsGen.Generate().ToString();
					if (types[j] == strName)
						ss[j] = strsGen.Generate();
				}

				res.Add(string.Join("\t", ss));
			}

			return res;
		}
	}
}
