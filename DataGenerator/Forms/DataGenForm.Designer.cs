namespace EugeneAnykey.Project.DataGenerator.Forms
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
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.rowsCountControl1 = new EugeneAnykey.Project.DataGenerator.Forms.RowsCountControl();
			this.columnsEditControl1 = new EugeneAnykey.Project.DataGenerator.Forms.ColumnsEditControl();
			this.toolStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.menuFileGenerate = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuAbout});
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
            this.menuExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "&File";
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(180, 22);
			this.menuExit.Text = "&Exit";
			// 
			// menuAbout
			// 
			this.menuAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.Size = new System.Drawing.Size(52, 20);
			this.menuAbout.Text = "&About";
			// 
			// rowsCountControl1
			// 
			this.rowsCountControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.rowsCountControl1.Location = new System.Drawing.Point(0, 24);
			this.rowsCountControl1.Name = "rowsCountControl1";
			this.rowsCountControl1.Padding = new System.Windows.Forms.Padding(4);
			this.rowsCountControl1.Size = new System.Drawing.Size(526, 67);
			this.rowsCountControl1.TabIndex = 9;
			// 
			// columnsEditControl1
			// 
			this.columnsEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.columnsEditControl1.Location = new System.Drawing.Point(0, 91);
			this.columnsEditControl1.Name = "columnsEditControl1";
			this.columnsEditControl1.Padding = new System.Windows.Forms.Padding(4);
			this.columnsEditControl1.Size = new System.Drawing.Size(526, 438);
			this.columnsEditControl1.TabIndex = 16;
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
			// menuFileGenerate
			// 
			this.menuFileGenerate.Name = "menuFileGenerate";
			this.menuFileGenerate.Size = new System.Drawing.Size(180, 22);
			this.menuFileGenerate.Text = "&Generate...";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
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
	}
}

