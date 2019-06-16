using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class MaskedIdsGen : BaseGen, IGen<string>, IStringOutputer
	{
		// const
		const string predefDigits = "0123456789";
		const string predefLatin = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		const string predefRus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЪЫЭЮЯ";
		const string predefAutos = "ABCEHKMNOPTXY";



		// helpers
		static char OneOf(string s) => s[R.Next(s.Length)];



		// field
		public string Mask { get; }
		readonly char[] symbols;

		public override string Name { get; set; } = "Masked Ids Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public MaskedIdsGen(string mask)
		{
			Mask = mask;
			symbols = mask.ToCharArray();
		}



		// predefined
		const char PredefMaskDigit = '#';   // 'D'
		const char PredefMaskAutos = '^';   // 'Z'
		const char PredefMaskLatin = '$';   // 'L'
		const char PredefMaskRus = '%';   // 'R'



		// Generate
		public string Generate()
		{
			char[] res = new char[symbols.Length];
			symbols.CopyTo(res, 0);
			
			for (int i = 0; i < res.Length; i++)
			{
				char replace =
					res[i] == PredefMaskDigit ? OneOf(predefDigits) :
					res[i] == PredefMaskAutos ? OneOf(predefAutos) :
					res[i] == PredefMaskLatin ? OneOf(predefLatin) :
					res[i] == PredefMaskRus ? OneOf(predefRus) :
					res[i];

				if (replace != res[i])
					res[i] = replace;
			}

			return new string(res);
		}

		public IEnumerable<string> Generate(int count) => Fill(count, () => Generate());



		// Output
		public string Output() => Generate();

		public IEnumerable<string> Output(int count) => Latest = Generate(count) as string[];
	}
}
