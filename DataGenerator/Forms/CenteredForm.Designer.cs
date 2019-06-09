namespace EugeneAnykey.Project.DataGenerator.Forms
{
	partial class CenteredForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CenteredForm));
			this.buttonOpenDataGenForm = new System.Windows.Forms.Button();
			this.buttonOpenColumnGeneratorForm = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuForms = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFormsColumnGenerator = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFormsDataGen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonOpenDataGenForm
			// 
			this.buttonOpenDataGenForm.Location = new System.Drawing.Point(55, 84);
			this.buttonOpenDataGenForm.Name = "buttonOpenDataGenForm";
			this.buttonOpenDataGenForm.Size = new System.Drawing.Size(215, 23);
			this.buttonOpenDataGenForm.TabIndex = 0;
			this.buttonOpenDataGenForm.Text = "Open Data Gen Form...";
			this.buttonOpenDataGenForm.UseVisualStyleBackColor = true;
			// 
			// buttonOpenColumnGeneratorForm
			// 
			this.buttonOpenColumnGeneratorForm.Location = new System.Drawing.Point(55, 43);
			this.buttonOpenColumnGeneratorForm.Name = "buttonOpenColumnGeneratorForm";
			this.buttonOpenColumnGeneratorForm.Size = new System.Drawing.Size(215, 23);
			this.buttonOpenColumnGeneratorForm.TabIndex = 1;
			this.buttonOpenColumnGeneratorForm.Text = "Open Column Generator Form...";
			this.buttonOpenColumnGeneratorForm.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuForms,
            this.menuAbout});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(326, 24);
			this.menuStrip1.TabIndex = 10;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "&File";
			// 
			// menuExit
			// 
			this.menuExit.Name = "menuExit";
			this.menuExit.Size = new System.Drawing.Size(92, 22);
			this.menuExit.Text = "&Exit";
			// 
			// menuForms
			// 
			this.menuForms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFormsColumnGenerator,
            this.menuFormsDataGen});
			this.menuForms.Name = "menuForms";
			this.menuForms.Size = new System.Drawing.Size(52, 20);
			this.menuForms.Text = "F&orms";
			// 
			// menuFormsColumnGenerator
			// 
			this.menuFormsColumnGenerator.Name = "menuFormsColumnGenerator";
			this.menuFormsColumnGenerator.Size = new System.Drawing.Size(181, 22);
			this.menuFormsColumnGenerator.Text = "&Column Generator...";
			// 
			// menuFormsDataGen
			// 
			this.menuFormsDataGen.Name = "menuFormsDataGen";
			this.menuFormsDataGen.Size = new System.Drawing.Size(181, 22);
			this.menuFormsDataGen.Text = "&Data Gen...";
			// 
			// menuAbout
			// 
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.Size = new System.Drawing.Size(52, 20);
			this.menuAbout.Text = "&About";
			// 
			// CenteredForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 175);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.buttonOpenColumnGeneratorForm);
			this.Controls.Add(this.buttonOpenDataGenForm);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CenteredForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CenteredForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOpenDataGenForm;
		private System.Windows.Forms.Button buttonOpenColumnGeneratorForm;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuExit;
		private System.Windows.Forms.ToolStripMenuItem menuForms;
		private System.Windows.Forms.ToolStripMenuItem menuFormsColumnGenerator;
		private System.Windows.Forms.ToolStripMenuItem menuAbout;
		private System.Windows.Forms.ToolStripMenuItem menuFormsDataGen;
	}
}