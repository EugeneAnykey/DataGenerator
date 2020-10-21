using System;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class RowsCountControl : UserControl
	{
		#region const
		readonly double[] mults = new[] { 1, 1e3, 1e6 };
		readonly string[] multsNames = new[] { "", "k", "M" };
		#endregion


		#region events: GenerateFile
		public event EventHandler GenerateFile;
		void OnGenerateFile() => GenerateFile?.Invoke(this, EventArgs.Empty);
		#endregion


		#region field: RowsCount, RowsCountShort
		public int RowsCount { get; private set; }
		public string RowsCountShort => GetRowsCountShort();
		#endregion


		#region init
		public RowsCountControl()
		{
			InitializeComponent();

			numericUpDownRows.Minimum = 1;
			numericUpDownRows.Maximum = 999;
			numericUpDownRows.Value = 100;
			
			buttonMult.Values = multsNames;
			buttonMult.ValuePosition = 1;

			numericUpDownRows.ValueChanged += (_, __) => CalcRowsCount();
			buttonMult.ValuePositionChanged += (_,__) => CalcRowsCount();
			
			buttonGenFile.Click += (_, __) => OnGenerateFile();

			CalcRowsCount();
		}
		#endregion


		#region private: CalcRowsCount, GetRowsCountShort
		void CalcRowsCount() => RowsCount = (int)numericUpDownRows.Value * (int)mults[buttonMult.ValuePosition];

		string GetRowsCountShort() => $"{(int)numericUpDownRows.Value}{buttonMult.Text}";
		#endregion
	}
}
