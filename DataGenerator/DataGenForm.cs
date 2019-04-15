﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator
{
	public partial class DataGenForm : Form
	{
		#region inner Helper: ShowAbout.
		void ShowAbout(object sender, EventArgs e)
		{
			var date = "2019-04-15";
			MessageBox.Show(
				$"{Application.ProductName}\n version: {Application.ProductVersion} from {date}\n Copyright (c) 2019 Eugene Anykey Software.\nAll Rights Reserved.",
				"About " + Application.ProductName,
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			);
		}
		#endregion

		#region field
		DataGen gen = new DataGen();
		Stopwatch watch = new Stopwatch();
		#endregion

		#region init
		public DataGenForm()
		{
			InitializeComponent();
			Text = Application.ProductName;

			Init();
			InitEvent();
		}

		void Init()
		{
			saveFileDialog1.Filter = "Text file (*.txt)|*.txt";
			labelElapsed.Text = $"Elapsed: n/a.";

			comboBoxRowsMult.Items.Clear();
			comboBoxRowsMult.Items.AddRange(new[] { "", "k", "M" });
			comboBoxRowsMult.SelectedIndex = 1;

			numericUpDownRows.Minimum = 1;
			numericUpDownRows.Maximum = 999;
			numericUpDownRows.Value = 100;

			numericUpDownColumns.Minimum = 1;
			numericUpDownColumns.Maximum = 999;
			numericUpDownColumns.Value = 20;
		}

		private void InitEvent()
		{
			buttonAbout.Click += ShowAbout;
		}
		#endregion

		#region private: GetRowsCount (+Short), ShowElapsed.
		int GetRowsCount()
		{
			var rows = (int)numericUpDownRows.Value;
			if (comboBoxRowsMult.Text == "k")
				rows *= (int)1e3;
			else
			if (comboBoxRowsMult.Text == "M")
				rows *= (int)1e6;

			return rows;
		}

		string GetRowsCountShort()
		{
			return $"{(int)numericUpDownRows.Value}{comboBoxRowsMult.Text}";
		}

		void ShowElapsed()
		{
			labelElapsed.Text = $"Elapsed: {watch.Elapsed}.";
		}

		void ShowElapsed(float percents)
		{
			labelElapsed.Text = $"Done: {100*percents:N2}%.\nElapsed: {watch.Elapsed}.";
		}
		#endregion

		#region events handlers
		private async void ButtonGenFile_Click(object sender, EventArgs e)
		{
			var rows = GetRowsCount();
			var cols = (int)numericUpDownColumns.Value;

			saveFileDialog1.FileName = $"random_r{GetRowsCountShort()}_c{cols}.txt";

			var filename = string.Empty;
			if (DialogResult.OK != saveFileDialog1.ShowDialog())
			{
				return;
			}

			watch.Start();

			string[] types = gen.GenerateTypes(true, cols);

			var progress = new Progress<float>( v => ShowElapsed(v) );

			await Task.Run(() => DoWork(filename, rows, types, progress));

			watch.Stop();
			ShowElapsed();
		}

		public void DoWork(string filename, int rows, string[] types, IProgress<float> progress)
		{
			gen.GenerateFile(saveFileDialog1.FileName, rows, types, progress);
		}
		#endregion
	}
}
