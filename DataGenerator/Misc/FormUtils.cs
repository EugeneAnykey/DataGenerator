using System;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Misc
{
	public static class FormUtils
	{
		public static void ShowAbout(object sender, EventArgs e)
		{
			var date = "2019-06-10";

			MessageBox.Show(
				$"{Application.ProductName}\n version: {Application.ProductVersion} from {date}\n Copyright (c) 2019 Eugene Anykey Software.\nAll Rights Reserved.",
				"About " + Application.ProductName,
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}
	}
}
