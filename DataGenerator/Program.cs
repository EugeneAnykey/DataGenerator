using System;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new DataGenForm());
		}
	}
}
