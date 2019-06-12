namespace EugeneAnykey.Forms.Controls
{
	partial class CollapsableControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelHor = new System.Windows.Forms.Label();
			this.workingPanel = new System.Windows.Forms.Panel();
			this.labelVer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label
			// 
			this.labelHor.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelHor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHor.Location = new System.Drawing.Point(4, 4);
			this.labelHor.Name = "label";
			this.labelHor.Size = new System.Drawing.Size(212, 14);
			this.labelHor.TabIndex = 1;
			this.labelHor.Text = "label1";
			this.labelHor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// workingPanel
			// 
			this.workingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.workingPanel.Location = new System.Drawing.Point(17, 18);
			this.workingPanel.Name = "workingPanel";
			this.workingPanel.Size = new System.Drawing.Size(199, 101);
			this.workingPanel.TabIndex = 2;
			// 
			// label1
			// 
			this.labelVer.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelVer.Location = new System.Drawing.Point(4, 18);
			this.labelVer.Name = "label1";
			this.labelVer.Size = new System.Drawing.Size(13, 101);
			this.labelVer.TabIndex = 3;
			this.labelVer.Text = "label1";
			this.labelVer.Visible = false;
			// 
			// CollapsableControl
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.workingPanel);
			this.Controls.Add(this.labelVer);
			this.Controls.Add(this.labelHor);
			this.Name = "CollapsableControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(220, 123);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label labelVer;
		public System.Windows.Forms.Panel workingPanel;
		private System.Windows.Forms.Label labelHor;
	}
}
