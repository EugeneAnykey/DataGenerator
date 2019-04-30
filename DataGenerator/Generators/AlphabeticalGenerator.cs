using System;
using System.Linq;
using System.Text;

namespace EugeneAnykey.Project.DataGenerator
{
	public static class AlphabeticalGenerator
	{
		// const
		const string latin = "abcdefghijklmnopqrstuvwxyz";
		const int minItems = 5;
		const int addMoreItems = 3;
		const string qSign = "?";
		const string bracketOpen = "[";
		const string bracketClose = "]";
		const string empty = "";
		const string separator = ",";



		public static string GenerateLines_Alphabetical(int lines, bool includeQuestionSign, bool excludeBrakets)
		{
			string s = includeQuestionSign ?
				latin + qSign :
				latin;

			if (lines < 1)
				lines = 250;

			var r = new Random(DateTime.Now.Millisecond);
			var sb = new StringBuilder();

			for (int i = 0; i < lines; i++)
			{
				var arr = new string[minItems + r.Next(addMoreItems)];
				for (int j = 0; j < arr.Length; j++)
				{
					arr[j] = s[r.Next(s.Length)].ToString();
				}

				string res = ConvertToString(arr, separator);
				if (excludeBrakets)
					res = res.Replace(bracketOpen, empty).Replace(bracketClose, empty);

				sb.AppendLine(res);
			}

			return sb.ToString();
		}



		public static string ConvertToString<T>(T[] array, string separator)
		{
			const string defaultSeparator = " ";
			const string noElements = "[]";
			const string bracketOpen = "[";
			const string bracketClose = "]";

			if (array == null) return string.Empty;

			if (array.Length == 0) return noElements;

			if (string.IsNullOrEmpty(separator)) separator = defaultSeparator;
			
			var res = string.Join(
				separator,
				array.Where(x => x != null).Select(x => x.ToString())
			);

			return string.Concat(
				bracketOpen,
				res,
				bracketClose
			);
		}
	}
}