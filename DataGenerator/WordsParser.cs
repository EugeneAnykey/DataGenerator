using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EugeneAnykey.Project.DataGenerator
{
	public static class WordsParser
	{
		#region static: MakeWords.
		public static string[] MakeWords(string filename)
		{
			var set = new HashSet<string>();

			MakeWordsSet(set, filename);

			return set.ToArray();
		}

		public static string[] MakeWords(string[] filenames)
		{
			var set = new HashSet<string>();

			foreach (var filename in filenames)
			{
				MakeWordsSet(set, filename);
			}

			return set.ToArray();
		}
		#endregion

		#region private: MakeWordsSet.
		static void MakeWordsSet(HashSet<string> set, string filename)
		{
			char[] seps = new[] { ' ', ',', '.', '\r', '\t', '\n' };

			var line = File.ReadAllText(filename).ToLower();
			set.UnionWith(line.Split(seps, StringSplitOptions.RemoveEmptyEntries));
		}
		#endregion
	}
}
