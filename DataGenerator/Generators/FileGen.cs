using System;
using System.Collections.Generic;
using System.IO;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class FileGen
	{
		// const
		const int defaultRowsPortion = 2460;



		// init
		public FileGen() { }



		// gen file
		public void GenerateFile(string filename, int totalRows, string[] types, Func<int, string[], IEnumerable<string>> getLinesFunc)
		{
			GenerateFile(filename, totalRows, types, getLinesFunc, null);
		}



		// gen file with progress output
		public void GenerateFile(string filename, int totalRows, string[] types, Func<int, string[], IEnumerable<string>> getLinesFunc, IProgress<float> progress)
		{
			// getLinesFunc is Func<int, string[], IEnumerable<string>> for 'count', 'types' that returns newLines.
			using (File.Create(filename)) { }

			int rowsDone = 0;

			while (totalRows - rowsDone > 0)
			{
				int currentRowsPortion = totalRows - rowsDone > defaultRowsPortion ? defaultRowsPortion : totalRows - rowsDone;

				IEnumerable<string> lines = getLinesFunc(currentRowsPortion, types);
				File.AppendAllLines(filename, lines);
				rowsDone += currentRowsPortion;

				if (progress != null)
					progress.Report((float)rowsDone / totalRows);
			}
		}



		// gen file with IGen types
		public void GenerateFile<T>(string filename, int totalRows, IGen<T>[] types, Func<int, IGen<T>[], IEnumerable<string>> getLinesFunc, IProgress<float> progress)
		{
			// getLinesFunc is Func<int, string[], IEnumerable<string>> for 'count', 'types' that returns newLines.
			using (File.Create(filename)) { }

			int rowsDone = 0;

			while (totalRows - rowsDone > 0)
			{
				int currentRowsPortion = totalRows - rowsDone > defaultRowsPortion ? defaultRowsPortion : totalRows - rowsDone;

				//IEnumerable<string> lines = getLinesFunc(currentRowsPortion, types);
				IEnumerable<string> lines = new string[0];
				File.AppendAllLines(filename, lines);
				rowsDone += currentRowsPortion;

				if (progress != null)
					progress.Report((float)rowsDone / totalRows);
			}
		}
	}
}
