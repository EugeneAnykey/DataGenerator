namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	partial class RndSymbolsParamsControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBoxLength = new System.Windows.Forms.GroupBox();
			this.labelLengthMax = new System.Windows.Forms.Label();
			this.numericUpDownLengthMax = new System.Windows.Forms.NumericUpDown();
			this.labelLengthMin = new System.Windows.Forms.Label();
			this.numericUpDownLengthMin = new System.Windows.Forms.NumericUpDown();
			this.labelLengthAvg = new System.Windows.Forms.Label();
			this.numericUpDownLengthAvg = new System.Windows.Forms.NumericUpDown();
			this.groupBoxDefaultSymbols = new System.Windows.Forms.GroupBox();
			this.listBoxDefaultSymbols = new System.Windows.Forms.ListBox();
			this.groupBoxAdditionalSymbols = new System.Windows.Forms.GroupBox();
			this.textBoxAdditionalSymbols = new System.Windows.Forms.TextBox();
			this.groupBoxLength.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLengthMax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLengthMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLengthAvg)).BeginInit();
			this.groupBoxDefaultSymbols.SuspendLayout();
			this.groupBoxAdditionalSymbols.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxLength
			// 
			this.groupBoxLength.Controls.Add(this.labelLengthMax);
			this.groupBoxLength.Controls.Add(this.numericUpDownLengthMax);
			this.groupBoxLength.Controls.Add(this.labelLengthMin);
			this.groupBoxLength.Controls.Add(this.numericUpDownLengthMin);
			this.groupBoxLength.Controls.Add(this.labelLengthAvg);
			this.groupBoxLength.Controls.Add(this.numericUpDownLengthAvg);
			this.groupBoxLength.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxLength.Location = new System.Drawing.Point(4, 4);
			this.groupBoxLength.Name = "groupBoxLength";
			this.groupBoxLength.Size = new System.Drawing.Size(263, 74);
			this.groupBoxLength.TabIndex = 16;
			this.groupBoxLength.TabStop = false;
			this.groupBoxLength.Text = "Length:";
			// 
			// labelLengthMax
			// 
			this.labelLengthMax.AutoSize = true;
			this.labelLengthMax.Location = new System.Drawing.Point(132, 16);
			this.labelLengthMax.Name = "labelLengthMax";
			this.labelLengthMax.Size = new System.Drawing.Size(30, 13);
			this.labelLengthMax.TabIndex = 21;
			this.labelLengthMax.Text = "Max:";
			// 
			// numericUpDownLengthMax
			// 
			this.numericUpDownLengthMax.Location = new System.Drawing.Point(170, 14);
			this.numericUpDownLengthMax.Name = "numericUpDownLengthMax";
			this.numericUpDownLengthMax.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownLengthMax.TabIndex = 20;
			// 
			// labelLengthMin
			// 
			this.labelLengthMin.AutoSize = true;
			this.labelLengthMin.Location = new System.Drawing.Point(6, 16);
			this.labelLengthMin.Name = "labelLengthMin";
			this.labelLengthMin.Size = new System.Drawing.Size(27, 13);
			this.labelLengthMin.TabIndex = 19;
			this.labelLengthMin.Text = "Min:";
			// 
			// numericUpDownLengthMin
			// 
			this.numericUpDownLengthMin.Location = new System.Drawing.Point(39, 14);
			this.numericUpDownLengthMin.Name = "numericUpDownLengthMin";
			this.numericUpDownLengthMin.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownLengthMin.TabIndex = 18;
			// 
			// labelLengthAvg
			// 
			this.labelLengthAvg.AutoSize = true;
			this.labelLengthAvg.Location = new System.Drawing.Point(6, 43);
			this.labelLengthAvg.Name = "labelLengthAvg";
			this.labelLengthAvg.Size = new System.Drawing.Size(29, 13);
			this.labelLengthAvg.TabIndex = 17;
			this.labelLengthAvg.Text = "Avg:";
			this.labelLengthAvg.Visible = false;
			// 
			// numericUpDownLengthAvg
			// 
			this.numericUpDownLengthAvg.Location = new System.Drawing.Point(39, 41);
			this.numericUpDownLengthAvg.Name = "numericUpDownLengthAvg";
			this.numericUpDownLengthAvg.Size = new System.Drawing.Size(87, 20);
			this.numericUpDownLengthAvg.TabIndex = 16;
			this.numericUpDownLengthAvg.Visible = false;
			// 
			// groupBoxDefaultSymbols
			// 
			this.groupBoxDefaultSymbols.Controls.Add(this.listBoxDefaultSymbols);
			this.groupBoxDefaultSymbols.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxDefaultSymbols.Location = new System.Drawing.Point(4, 78);
			this.groupBoxDefaultSymbols.Name = "groupBoxDefaultSymbols";
			this.groupBoxDefaultSymbols.Size = new System.Drawing.Size(263, 104);
			this.groupBoxDefaultSymbols.TabIndex = 18;
			this.groupBoxDefaultSymbols.TabStop = false;
			this.groupBoxDefaultSymbols.Text = "Default used symbols";
			// 
			// listBoxDefaultSymbols
			// 
			this.listBoxDefaultSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxDefaultSymbols.FormattingEnabled = true;
			this.listBoxDefaultSymbols.Location = new System.Drawing.Point(3, 16);
			this.listBoxDefaultSymbols.Name = "listBoxDefaultSymbols";
			this.listBoxDefaultSymbols.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBoxDefaultSymbols.Size = new System.Drawing.Size(257, 85);
			this.listBoxDefaultSymbols.TabIndex = 12;
			// 
			// groupBoxAdditionalSymbols
			// 
			this.groupBoxAdditionalSymbols.Controls.Add(this.textBoxAdditionalSymbols);
			this.groupBoxAdditionalSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxAdditionalSymbols.Location = new System.Drawing.Point(4, 182);
			this.groupBoxAdditionalSymbols.Name = "groupBoxAdditionalSymbols";
			this.groupBoxAdditionalSymbols.Size = new System.Drawing.Size(263, 102);
			this.groupBoxAdditionalSymbols.TabIndex = 19;
			this.groupBoxAdditionalSymbols.TabStop = false;
			this.groupBoxAdditionalSymbols.Text = "Additional symbols";
			// 
			// textBoxAdditionalSymbols
			// 
			this.textBoxAdditionalSymbols.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxAdditionalSymbols.Location = new System.Drawing.Point(3, 16);
			this.textBoxAdditionalSymbols.Multiline = true;
			this.textBoxAdditionalSymbols.Name = "textBoxAdditionalSymbols";
			this.textBoxAdditionalSymbols.Size = new System.Drawing.Size(257, 83);
			this.textBoxAdditionalSymbols.TabIndex = 15;
			// 
			// RndSymbolsParamsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxAdditionalSymbols);
			this.Controls.Add(this.groupBoxDefaultSymbols);
			this.Controls.Add(this.groupBoxLength);
			this.Name = "RndSymbolsParamsControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(271, 288);
			this.groupBoxLength.ResumeLayout(false);
			this.groupBoxLength.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLengthMax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLengthMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLengthAvg)).EndInit();
			this.groupBoxDefaultSymbols.ResumeLayout(false);
			this.groupBoxAdditionalSymbols.ResumeLayout(false);
			this.groupBoxAdditionalSymbols.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBoxLength;
		private System.Windows.Forms.Label labelLengthMax;
		private System.Windows.Forms.NumericUpDown numericUpDownLengthMax;
		private System.Windows.Forms.Label labelLengthMin;
		private System.Windows.Forms.NumericUpDown numericUpDownLengthMin;
		private System.Windows.Forms.Label labelLengthAvg;
		private System.Windows.Forms.NumericUpDown numericUpDownLengthAvg;
		private System.Windows.Forms.GroupBox groupBoxDefaultSymbols;
		private System.Windows.Forms.ListBox listBoxDefaultSymbols;
		private System.Windows.Forms.GroupBox groupBoxAdditionalSymbols;
		private System.Windows.Forms.TextBox textBoxAdditionalSymbols;
	}
}
