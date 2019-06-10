using System;
using System.Reflection;
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



		// NumericUpDown
		public static void NumericsUpdate(this NumericUpDown control, decimal min, decimal max, decimal val)
		{
			if (min > max)
			{
				var t = max;
				max = min;
				min = t;
			}

			val = min > val ? min : max < val ? max : val;

			// need to be tested HARDER!!!

			control.Minimum = min;
			control.Maximum = max;
			control.SetNumericUpDownValue(val);
		}

		public static void SetNumericUpDownValue(this NumericUpDown control, decimal value)
		{
			if (control == null) throw new ArgumentNullException(nameof(control));
			var currentValueField = control.GetType().GetField("currentValue", BindingFlags.Instance | BindingFlags.NonPublic);
			if (currentValueField != null)
			{
				currentValueField.SetValue(control, value);
				control.Text = value.ToString();
			}
		}
	}
}
