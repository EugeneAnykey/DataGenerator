using System;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	[Obsolete]
	public class DataGen
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
		static int idGen;

		static string[] engWords = WordsHolder.EngWords;



		// init
		public DataGen() { }



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
			var floatsGen = new FloatsGen(0, 100000, 2);
			var intsGen = new IntegersGen(0, 1000);

			var res = new List<string>();

			int cols = types.Length;

			res.Add(string.Join("\t", types));

			for (int i = 0; i < rows; i++)
			{
				var ss = new string[cols];
				for (int j = 0; j < cols; j++)
				{
					if (types[j] == idName)
						ss[j] = idGen++.ToString();
					if (types[j] == numName)
						ss[j] = intsGen.Generate().ToString();//GenerateNum(0, 1000).ToString();
					if (types[j] == floatName)
						ss[j] = floatsGen.Generate().ToString();//GenerateFloat(100000).ToString();
					if (types[j] == strName)
						ss[j] = GenerateString(6);
				}

				res.Add(string.Join("\t", ss));
			}

			return res;
		}



		// private: gen data
		[Obsolete]
		int GenerateNum(int min, int max) => Randomizer.R.Next(min, max);

		[Obsolete]
		float GenerateFloat(int max) => Randomizer.R.Next(max) / 100.0f;
		
		[Obsolete]
		float GenerateFloat(int min, int max, float divisor) => Randomizer.R.Next(min, max) / divisor;

		string GenerateString() => engWords[Randomizer.R.Next(engWords.Length)];

		string GenerateString(int maxLength)
		{
			var s = engWords[Randomizer.R.Next(engWords.Length)];
			if (s.Length > maxLength)
			{
				s = s.Substring(0, maxLength);
			}
			return s;
		}
	}
}
