using System;
using System.Linq;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator
{
	/// <summary>
	/// Создает и обновляет подсказку-пример генератора у указанного контрола
	/// </summary>
	public class Exampler
	{
		#region field
		public Control ToolTipControl;
		public Func<BaseGen> GenFunc;
		
		readonly ToolTip toolTip = new ToolTip();
		string latestExample = "";
		#endregion

		#region init
		public Exampler(Control toolTipControl, Func<BaseGen> gen)
		{
			ToolTipControl = toolTipControl;
			GenFunc = gen;

			ToolTipControl.MouseEnter += (_, __) => { UpdateExample(); };
			ToolTipControl.MouseClick += (_, __) => { Clipboard.SetText(latestExample); };
		}
		#endregion


		#region private
		void UpdateExample()
		{
			latestExample = GetExample(GenFunc());
			toolTip.SetToolTip(ToolTipControl, latestExample);
		}

		static string GetExample(BaseGen gen)
		{
			const int ExampleLines = 20;
			const int MaxLineLength = 40;
			const string NewLine = "\r\n";
			int i = 1;
			string Shorten(string s) => s.Length > MaxLineLength ? s.Substring(0, MaxLineLength) + "…" : s;
			var arr = (gen as IStringOutputer).Output(ExampleLines).Select(s => $"{i++}. {Shorten(s)}");
			return string.Concat("Example:" + NewLine, string.Join(NewLine, arr));
		}
		#endregion
	}
}
