namespace EugeneAnykey.Project.DataGenerator.Forms
{
	partial class ColumnGeneratorForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColumnGeneratorForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonCopyColumns = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonGenerate = new System.Windows.Forms.Button();
			this.groupBoxColumns = new System.Windows.Forms.GroupBox();
			this.listBoxResultedColumns = new System.Windows.Forms.ListBox();
			this.groupBoxItems = new System.Windows.Forms.GroupBox();
			this.textBoxItems = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.comboBoxItemsSeparator = new System.Windows.Forms.ComboBox();
			this.labelItemsSeparator = new System.Windows.Forms.Label();
			this.buttonFastExample = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBoxColumns.SuspendLayout();
			this.groupBoxItems.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonCopyColumns);
			this.panel1.Controls.Add(this.buttonClose);
			this.panel1.Controls.Add(this.buttonGenerate);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 388);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(352, 36);
			this.panel1.TabIndex = 3;
			// 
			// buttonCopyColumns
			// 
			this.buttonCopyColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCopyColumns.Location = new System.Drawing.Point(117, 3);
			this.buttonCopyColumns.Name = "buttonCopyColumns";
			this.buttonCopyColumns.Size = new System.Drawing.Size(114, 23);
			this.buttonCopyColumns.TabIndex = 5;
			this.buttonCopyColumns.Text = "Copy Columns";
			this.buttonCopyColumns.UseVisualStyleBackColor = true;
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(264, 3);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 4;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			// 
			// buttonGenerate
			// 
			this.buttonGenerate.Location = new System.Drawing.Point(12, 3);
			this.buttonGenerate.Name = "buttonGenerate";
			this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
			this.buttonGenerate.TabIndex = 3;
			this.buttonGenerate.Text = "Generate";
			this.buttonGenerate.UseVisualStyleBackColor = true;
			// 
			// groupBoxColumns
			// 
			this.groupBoxColumns.Controls.Add(this.listBoxResultedColumns);
			this.groupBoxColumns.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxColumns.Location = new System.Drawing.Point(0, 131);
			this.groupBoxColumns.Name = "groupBoxColumns";
			this.groupBoxColumns.Size = new System.Drawing.Size(352, 257);
			this.groupBoxColumns.TabIndex = 6;
			this.groupBoxColumns.TabStop = false;
			this.groupBoxColumns.Text = "Resulted Columns:";
			// 
			// listBoxResultedColumns
			// 
			this.listBoxResultedColumns.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxResultedColumns.FormattingEnabled = true;
			this.listBoxResultedColumns.Location = new System.Drawing.Point(3, 16);
			this.listBoxResultedColumns.Name = "listBoxResultedColumns";
			this.listBoxResultedColumns.Size = new System.Drawing.Size(346, 238);
			this.listBoxResultedColumns.TabIndex = 0;
			// 
			// groupBoxItems
			// 
			this.groupBoxItems.Controls.Add(this.textBoxItems);
			this.groupBoxItems.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxItems.Location = new System.Drawing.Point(0, 39);
			this.groupBoxItems.Name = "groupBoxItems";
			this.groupBoxItems.Size = new System.Drawing.Size(352, 92);
			this.groupBoxItems.TabIndex = 7;
			this.groupBoxItems.TabStop = false;
			this.groupBoxItems.Text = "Items:";
			// 
			// textBoxItems
			// 
			this.textBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxItems.Location = new System.Drawing.Point(3, 16);
			this.textBoxItems.Multiline = true;
			this.textBoxItems.Name = "textBoxItems";
			this.textBoxItems.Size = new System.Drawing.Size(346, 73);
			this.textBoxItems.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.buttonFastExample);
			this.panel2.Controls.Add(this.comboBoxItemsSeparator);
			this.panel2.Controls.Add(this.labelItemsSeparator);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(352, 39);
			this.panel2.TabIndex = 8;
			// 
			// comboBoxItemsSeparator
			// 
			this.comboBoxItemsSeparator.FormattingEnabled = true;
			this.comboBoxItemsSeparator.Location = new System.Drawing.Point(99, 6);
			this.comboBoxItemsSeparator.Name = "comboBoxItemsSeparator";
			this.comboBoxItemsSeparator.Size = new System.Drawing.Size(125, 21);
			this.comboBoxItemsSeparator.TabIndex = 6;
			// 
			// labelItemsSeparator
			// 
			this.labelItemsSeparator.AutoSize = true;
			this.labelItemsSeparator.Location = new System.Drawing.Point(9, 9);
			this.labelItemsSeparator.Name = "labelItemsSeparator";
			this.labelItemsSeparator.Size = new System.Drawing.Size(84, 13);
			this.labelItemsSeparator.TabIndex = 5;
			this.labelItemsSeparator.Text = "Items Separator:";
			// 
			// buttonFastExample
			// 
			this.buttonFastExample.Location = new System.Drawing.Point(230, 6);
			this.buttonFastExample.Name = "buttonFastExample";
			this.buttonFastExample.Size = new System.Drawing.Size(110, 23);
			this.buttonFastExample.TabIndex = 7;
			this.buttonFastExample.Text = "Fast Example";
			this.buttonFastExample.UseVisualStyleBackColor = true;
			// 
			// ColumnGeneratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 424);
			this.Controls.Add(this.groupBoxColumns);
			this.Controls.Add(this.groupBoxItems);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(300, 400);
			this.Name = "ColumnGeneratorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Column Generator";
			this.panel1.ResumeLayout(false);
			this.groupBoxColumns.ResumeLayout(false);
			this.groupBoxItems.ResumeLayout(false);
			this.groupBoxItems.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonGenerate;
		private System.Windows.Forms.GroupBox groupBoxColumns;
		private System.Windows.Forms.ListBox listBoxResultedColumns;
		private System.Windows.Forms.GroupBox groupBoxItems;
		private System.Windows.Forms.TextBox textBoxItems;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox comboBoxItemsSeparator;
		private System.Windows.Forms.Label labelItemsSeparator;
		private System.Windows.Forms.Button buttonCopyColumns;
		private System.Windows.Forms.Button buttonFastExample;
	}
}