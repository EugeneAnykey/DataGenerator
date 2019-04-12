using System;
using System.Collections.Generic;
using System.IO;

namespace EugeneAnykey.Project.DataGenerator
{
	public class DataGen
	{
		#region const
		const int rowsPortion = 2460;

		const string idName = "id";
		const string strName = "string";
		const string numName = "numeric";
		const string floatName = "float";
		// not used currently:
		const string dateName = "date";
		const string timeName = "time";
		const string dateTimeName = "datetime";
		#endregion

		#region field
		static int idGen;

		static string[] engWords = WordsParser.MakeWords( new[] { "../../data/words.txt" });

		Random r = new Random((int)DateTime.UtcNow.Ticks);
		#endregion

		#region init
		public DataGen()
		{
			//Parse();
		}

		static void Parse()
		{
			// parsing words from texts:
			File.WriteAllLines(
				"placeHere.txt",
				WordsParser.MakeWords( new[] { "../../data/file1.txt", "../../data/file2.txt" })
			);
		}
		#endregion

		#region Gen file
		public void GenerateFile(string filename, int totalRows, string[] types)
		{
			using (File.Create(filename)) { }

			int rowsDone = 0;

			idGen = 0;
			while (totalRows - rowsDone > 0)
			{
				int nowRows = totalRows - rowsDone > rowsPortion ? rowsPortion : totalRows - rowsDone;

				IEnumerable<string> lines = GetLines(nowRows, types);
				File.AppendAllLines(filename, lines);
				rowsDone += rowsPortion;
			}
		}
		#endregion

		#region gen types
		public string[] GenerateTypes(bool needId, int cols)
		{
			var res = new List<string>();

			if (needId)
				res.Add(idName);

			int start = needId ? 1 : 0;

			for (int i = start; i < cols; i++)
			{
				switch (r.Next(1, 6))
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
		#endregion

		#region gen data
		int GenerateNum(int min, int max) => r.Next(min, max);

		float GenerateFloat(int max) => r.Next(max) / 100.0f;

		string GenerateString() => engWords[r.Next(engWords.Length)];

		string GenerateString(int maxLength)
		{
			var s = engWords[r.Next(engWords.Length)];
			if (s.Length > maxLength)
			{
				s = s.Substring(0, maxLength);
			}
			return s;
		}
		#endregion

		#region Gen lines
		IEnumerable<string> GetLines(int rows, string[] types)
		{
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
						ss[j] = GenerateNum(0, 1000).ToString();
					if (types[j] == floatName)
						ss[j] = GenerateFloat(100000).ToString();
					if (types[j] == strName)
						ss[j] = GenerateString(6);
				}

				res.Add(string.Join("\t", ss));
			}

			return res;
		}
		#endregion
	}
}
