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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileGenerate = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.menuRecolor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.columnsEditControl1 = new EugeneAnykey.Project.DataGenerator.Forms.ColumnsEditControl();
			this.rowsCountControl1 = new EugeneAnykey.Project.DataGenerator.Forms.RowsCountControl();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuAbout,
            this.menuRecolor});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(526, 24);
			this.menuStrip1.TabIndex = 12;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileGenerate,
            this.toolStripMenuItem1,
            this.menuFileOpen,
            this.menuFileSave,
            this.toolStripMenuItem2,
            this.menuExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "&File";
			// 
			// menuFileGenerate
			// 
			this.menuFileGenerate.Name = "menuFileGenerate";
			this.menuFileGenerate.Size = new System.Drawing.Size(156, 22);
			this.menuFileGenerate.Text = "&Generate...";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
			// 
			// menuFileOpen
			// 
			this.menuFileOpen.Name = "menuFileOpen";
			this.menuFileOpen.Size = new System.Drawing.Size(156, 22);
			this.menuFileOpen.Text = "&Open scheme...";
			// 
			// menuFileSave
			// 
			this.menuFileSave.Name = "menuFileSave";
			this.menuFileSave.Size = new System.Drawing.Size(156, 22);
			this.menuFileSave.Text = "&Save scheme...";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 6);
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(156, 22);
			this.menuExit.Text = "&Exit";
			// 
			// menuAbout
			// 
			this.menuAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.Size = new System.Drawing.Size(52, 20);
			this.menuAbout.Text = "&About";
			// 
			// menuRecolor
			// 
			this.menuRecolor.Name = "menuRecolor";
			this.menuRecolor.Size = new System.Drawing.Size(59, 20);
			this.menuRecolor.Text = "Recolor";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelStatus,
            this.toolStripProgressBar});
			this.toolStrip1.Location = new System.Drawing.Point(0, 529);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(526, 22);
			this.toolStrip1.TabIndex = 15;
			this.toolStrip1.Text = "statusStrip1";
			// 
			// toolStripLabelStatus
			// 
			this.toolStripLabelStatus.AutoSize = false;
			this.toolStripLabelStatus.Name = "toolStripLabelStatus";
			this.toolStripLabelStatus.Size = new System.Drawing.Size(150, 17);
			// 
			// toolStripProgressBar
			// 
			this.toolStripProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripProgressBar.AutoSize = false;
			this.toolStripProgressBar.Name = "toolStripProgressBar";
			this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBar.Value = 75;
			this.toolStripProgressBar.Visible = false;
			// 
			// columnsEditControl1
			// 
			this.columnsEditControl1.BackColor = System.Drawing.SystemColors.Control;
			this.columnsEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.columnsEditControl1.Location = new System.Drawing.Point(0, 85);
			this.columnsEditControl1.Name = "columnsEditControl1";
			this.columnsEditControl1.Padding = new System.Windows.Forms.Padding(4);
			this.columnsEditControl1.Size = new System.Drawing.Size(526, 444);
			this.columnsEditControl1.TabIndex = 16;
			// 
			// rowsCountControl1
			// 
			this.rowsCountControl1.BackColor = System.Drawing.SystemColors.Control;
			this.rowsCountControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.rowsCountControl1.Location = new System.Drawing.Point(0, 24);
			this.rowsCountControl1.Name = "rowsCountControl1";
			this.rowsCountControl1.Padding = new System.Windows.Forms.Padding(4);
			this.rowsCountControl1.Size = new System.Drawing.Size(526, 61);
			this.rowsCountControl1.TabIndex = 9;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// DataGenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 551);
			this.Controls.Add(this.columnsEditControl1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.rowsCountControl1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(800, 900);
			this.MinimumSize = new System.Drawing.Size(450, 500);
			this.Name = "DataGenForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private RowsCountControl rowsCountControl1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuExit;
		private System.Windows.Forms.ToolStripMenuItem menuAbout;
		private ColumnsEditControl columnsEditControl1;
		private System.Windows.Forms.StatusStrip toolStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripLabelStatus;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
		private System.Windows.Forms.ToolStripMenuItem menuFileGenerate;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem menuRecolor;
		private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
		private System.Windows.Forms.ToolStripMenuItem menuFileSave;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

