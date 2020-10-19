using System;
using System.Collections.Generic;
using System.IO;

namespace EugeneAnykey.Project.DataGenerator.IO
{
	public class FileGen
	{
		// const
		const int defaultRowsPortion = 2460;



		// init
		public FileGen() { }



		// public: GenerateBaseGenFile
		public void GenerateBaseGenFile(string filename, int rows, BaseGen[] gens, IProgress<float> progress)
		{
			var title = MakeTitleLine(gens);
			var outputers = ConvertGensToStringOutputers(gens);
			GenFile(filename, rows, title, outputers, progress);
		}




		IStringOutputer[] ConvertGensToStringOutputers(BaseGen[] gens)
		{
			var outputers = new IStringOutputer[gens.Length];
			for (int i = 0; i < gens.Length; i++)
			{
				outputers[i] = gens[i] as IStringOutputer;
			}
			return outputers;
		}

		void GenFile(string filename, int totalRows, string title, IStringOutputer[] outputers, IProgress<float> progress)
		{
			using (File.Create(filename)) { }

			if (title != null)
				File.AppendAllLines(filename, new[] { title });

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



		string MakeSingleLine(int index, IStringOutputer[] outputers)
		{
			const string separator = "\t";

			var res = new string[outputers.Length];

			for (int i = 0; i < outputers.Length; i++)
			{
				res[i] = outputers[i].Latest[index];
			}

			return string.Join(separator, res);
		}



		string MakeTitleLine(BaseGen[] gens)
		{
			if (gens == null)
			{
				throw new ArgumentNullException(nameof(gens));
			}

			const string separator = "\t";

			var res = new string[gens.Length];

			for (int i = 0; i < gens.Length; i++)
			{
				res[i] = gens[i].Name;
			}

			return string.Join(separator, res);
		}



		IEnumerable<string> MakeNewLinesPortion(int count, IStringOutputer[] outputers)
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



		void GenerateNewPortion(int count, IStringOutputer[] outputers)
		{
			for (int i = 0; i < outputers.Length; i++)
			{
				outputers[i].Output(count);
			}
		}
	}
}
