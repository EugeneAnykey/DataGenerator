﻿namespace EugeneAnykey.Project.DataGenerator.Forms
{
	partial class DataGenForm
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGenForm));
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.rowsCountControl1 = new EugeneAnykey.Project.DataGenerator.Forms.RowsCountControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonTest = new System.Windows.Forms.Button();
			this.labelElapsed = new System.Windows.Forms.Label();
			this.buttonGenFile = new System.Windows.Forms.Button();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageFixed = new System.Windows.Forms.TabPage();
			this.tabPageRandom = new System.Windows.Forms.TabPage();
			this.labelColumns = new System.Windows.Forms.Label();
			this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
			this.columnsEditControl1 = new EugeneAnykey.Project.DataGenerator.Forms.ColumnsEditControl();
			this.groupBox1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageFixed.SuspendLayout();
			this.tabPageRandom.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
			this.SuspendLayout();
			// 
			// rowsCountControl1
			// 
			this.rowsCountControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.rowsCountControl1.Location = new System.Drawing.Point(0, 0);
			this.rowsCountControl1.Name = "rowsCountControl1";
			this.rowsCountControl1.Padding = new System.Windows.Forms.Padding(4);
			this.rowsCountControl1.Size = new System.Drawing.Size(442, 67);
			this.rowsCountControl1.TabIndex = 9;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonTest);
			this.groupBox1.Controls.Add(this.labelElapsed);
			this.groupBox1.Controls.Add(this.buttonGenFile);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 377);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(442, 97);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// buttonTest
			// 
			this.buttonTest.Location = new System.Drawing.Point(192, 23);
			this.buttonTest.Name = "buttonTest";
			this.buttonTest.Size = new System.Drawing.Size(75, 23);
			this.buttonTest.TabIndex = 11;
			this.buttonTest.Text = "Test";
			this.buttonTest.UseVisualStyleBackColor = true;
			// 
			// labelElapsed
			// 
			this.labelElapsed.AutoSize = true;
			this.labelElapsed.Location = new System.Drawing.Point(12, 49);
			this.labelElapsed.Name = "labelElapsed";
			this.labelElapsed.Size = new System.Drawing.Size(48, 13);
			this.labelElapsed.TabIndex = 10;
			this.labelElapsed.Text = "Elapsed:";
			// 
			// buttonGenFile
			// 
			this.buttonGenFile.Location = new System.Drawing.Point(37, 23);
			this.buttonGenFile.Name = "buttonGenFile";
			this.buttonGenFile.Size = new System.Drawing.Size(120, 23);
			this.buttonGenFile.TabIndex = 9;
			this.buttonGenFile.Text = "Generate file...";
			this.buttonGenFile.UseVisualStyleBackColor = true;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageFixed);
			this.tabControl.Controls.Add(this.tabPageRandom);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 67);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(442, 310);
			this.tabControl.TabIndex = 11;
			// 
			// tabPageFixed
			// 
			this.tabPageFixed.Controls.Add(this.columnsEditControl1);
			this.tabPageFixed.Location = new System.Drawing.Point(4, 22);
			this.tabPageFixed.Name = "tabPageFixed";
			this.tabPageFixed.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFixed.Size = new System.Drawing.Size(434, 284);
			this.tabPageFixed.TabIndex = 0;
			this.tabPageFixed.Text = "Fixed Columns";
			this.tabPageFixed.UseVisualStyleBackColor = true;
			// 
			// tabPageRandom
			// 
			this.tabPageRandom.Controls.Add(this.labelColumns);
			this.tabPageRandom.Controls.Add(this.numericUpDownColumns);
			this.tabPageRandom.Location = new System.Drawing.Point(4, 22);
			this.tabPageRandom.Name = "tabPageRandom";
			this.tabPageRandom.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageRandom.Size = new System.Drawing.Size(434, 242);
			this.tabPageRandom.TabIndex = 1;
			this.tabPageRandom.Text = "Random Columns";
			this.tabPageRandom.UseVisualStyleBackColor = true;
			// 
			// labelColumns
			// 
			this.labelColumns.AutoSize = true;
			this.labelColumns.Location = new System.Drawing.Point(30, 19);
			this.labelColumns.Name = "labelColumns";
			this.labelColumns.Size = new System.Drawing.Size(81, 13);
			this.labelColumns.TabIndex = 9;
			this.labelColumns.Text = "Columns Count:";
			// 
			// numericUpDownColumns
			// 
			this.numericUpDownColumns.Location = new System.Drawing.Point(125, 17);
			this.numericUpDownColumns.Name = "numericUpDownColumns";
			this.numericUpDownColumns.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownColumns.TabIndex = 8;
			// 
			// columnsEditControl1
			// 
			this.columnsEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.columnsEditControl1.Location = new System.Drawing.Point(3, 3);
			this.columnsEditControl1.Name = "columnsEditControl1";
			this.columnsEditControl1.Padding = new System.Windows.Forms.Padding(4);
			this.columnsEditControl1.Size = new System.Drawing.Size(428, 278);
			this.columnsEditControl1.TabIndex = 0;
			// 
			// DataGenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 474);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.rowsCountControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DataGenForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageFixed.ResumeLayout(false);
			this.tabPageRandom.ResumeLayout(false);
			this.tabPageRandom.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private RowsCountControl rowsCountControl1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonTest;
		private System.Windows.Forms.Label labelElapsed;
		private System.Windows.Forms.Button buttonGenFile;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageFixed;
		private System.Windows.Forms.TabPage tabPageRandom;
		private System.Windows.Forms.Label labelColumns;
		private System.Windows.Forms.NumericUpDown numericUpDownColumns;
		private ColumnsEditControl columnsEditControl1;
	}
}

