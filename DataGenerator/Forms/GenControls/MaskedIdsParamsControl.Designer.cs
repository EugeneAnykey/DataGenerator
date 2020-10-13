namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	partial class MaskedIdsParamsControl
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
			this.labelMask = new System.Windows.Forms.Label();
			this.textBoxMask = new System.Windows.Forms.TextBox();
			this.labelTemplates = new System.Windows.Forms.Label();
			this.comboBoxTemplates = new System.Windows.Forms.ComboBox();
			this.labelHelp = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelMask
			// 
			this.labelMask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelMask.AutoSize = true;
			this.labelMask.Location = new System.Drawing.Point(10, 38);
			this.labelMask.Name = "labelMask";
			this.labelMask.Size = new System.Drawing.Size(36, 13);
			this.labelMask.TabIndex = 9;
			this.labelMask.Text = "Mask:";
			// 
			// textBoxMask
			// 
			this.textBoxMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxMask.Location = new System.Drawing.Point(48, 35);
			this.textBoxMask.Name = "textBoxMask";
			this.textBoxMask.Size = new System.Drawing.Size(177, 20);
			this.textBoxMask.TabIndex = 10;
			// 
			// labelTemplates
			// 
			this.labelTemplates.AutoSize = true;
			this.labelTemplates.Location = new System.Drawing.Point(10, 13);
			this.labelTemplates.Name = "labelTemplates";
			this.labelTemplates.Size = new System.Drawing.Size(56, 13);
			this.labelTemplates.TabIndex = 12;
			this.labelTemplates.Text = "Templates";
			// 
			// comboBoxTemplates
			// 
			this.comboBoxTemplates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxTemplates.FormattingEnabled = true;
			this.comboBoxTemplates.Location = new System.Drawing.Point(72, 7);
			this.comboBoxTemplates.Name = "comboBoxTemplates";
			this.comboBoxTemplates.Size = new System.Drawing.Size(153, 21);
			this.comboBoxTemplates.TabIndex = 13;
			// 
			// labelHelp
			// 
			this.labelHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelHelp.AutoSize = true;
			this.labelHelp.Location = new System.Drawing.Point(231, 38);
			this.labelHelp.Name = "labelHelp";
			this.labelHelp.Size = new System.Drawing.Size(13, 13);
			this.labelHelp.TabIndex = 14;
			this.labelHelp.Text = "?";
			// 
			// MaskedIdsParamsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelHelp);
			this.Controls.Add(this.comboBoxTemplates);
			this.Controls.Add(this.labelTemplates);
			this.Controls.Add(this.textBoxMask);
			this.Controls.Add(this.labelMask);
			this.Name = "MaskedIdsParamsControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(251, 64);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelMask;
		private System.Windows.Forms.TextBox textBoxMask;
		private System.Windows.Forms.Label labelTemplates;
		private System.Windows.Forms.ComboBox comboBoxTemplates;
		private System.Windows.Forms.Label labelHelp;
	}
}
