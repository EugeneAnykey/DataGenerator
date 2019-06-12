using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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



		// TEST
		public static void GenerateTestFile(string filename, int rows, BaseGen[] gens, IProgress<float> progress)
		{
			var outputers = GetStringOutputers(gens);
			GenFile(filename, rows, outputers, progress);
		}

		static IStringOutputer[] GetStringOutputers(BaseGen[] gens)
		{
			var outputers = new IStringOutputer[gens.Length];
			for (int i = 0; i < gens.Length; i++)
			{
				outputers[i] = gens[i] as IStringOutputer;
			}
			return outputers;
		}

		static void GenFile(string filename, int totalRows, IStringOutputer[] outputers, IProgress<float> progress)
		{
			using (File.Create(filename)) { }

			int rowsDone = 0;

			while (totalRows - rowsDone > 0)
			{
				int currentRowsPortion = totalRows - rowsDone > defaultRowsPortion ? defaultRowsPortion : totalRows - rowsDone;

				IEnumerable<string> lines = MakeNewLinesPortion(currentRowsPortion, outputers);
				File.AppendAllLines(filename, lines);
				rowsDone += currentRowsPortion;

				if (progress != null)
					progress.Report((float)rowsDone / totalRows);
			}
		}



		static string MakeSingleLine(int index, IStringOutputer[] outputers)
		{
			const string separator = "\t";
			
			var res = new string[outputers.Length];
			
			for (int i = 0; i < outputers.Length; i++)
			{
				res[i] = outputers[i].Latest[index];
			}

			return string.Join(separator, res);
		}



		static IEnumerable<string> MakeNewLinesPortion(int count, IStringOutputer[] outputers)
		{
			if (outputers == null)
			{
				throw new ArgumentNullException(nameof(outputers));
			}

			var res = new string[count];

			GenerateNewPortion(count, outputers);

			for (int i = 0; i < count; i++)
			{
				res[i] = MakeSingleLine(i, outputers);
			}

			return res;
		}

		static void GenerateNewPortion(int count, IStringOutputer[] outputers)
		{
			for (int i = 0; i < outputers.Length; i++)
			{
				outputers[i].Output(count);
			}
		}
	}
}
