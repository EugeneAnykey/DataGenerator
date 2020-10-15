using System.Linq;

namespace EugeneAnykey.Project.DataGenerator
{
	public static class Exampler
	{
		public static string GetExample(BaseGen gen)
		{
			const int ExampleLines = 20;
			const int MaxLineLength = 40;
			const string NewLine = "\r\n";
			int i = 1;
			string Shorten(string s) => s.Length > MaxLineLength ? s.Substring(0, MaxLineLength) + "…" : s;
			var arr = (gen as IStringOutputer).Output(ExampleLines).Select(s => $"{i++}. {Shorten(s)}");
			return string.Concat("Example:" + NewLine, string.Join(NewLine, arr));
		}
	}
}
