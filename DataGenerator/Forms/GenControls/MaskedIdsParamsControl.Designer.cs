﻿namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
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
			this.SuspendLayout();
			// 
			// labelMask
			// 
			this.labelMask.AutoSize = true;
			this.labelMask.Location = new System.Drawing.Point(10, 9);
			this.labelMask.Name = "labelMask";
			this.labelMask.Size = new System.Drawing.Size(36, 13);
			this.labelMask.TabIndex = 9;
			this.labelMask.Text = "Mask:";
			// 
			// textBoxMask
			// 
			this.textBoxMask.Location = new System.Drawing.Point(48, 6);
			this.textBoxMask.Name = "textBoxMask";
			this.textBoxMask.Size = new System.Drawing.Size(196, 20);
			this.textBoxMask.TabIndex = 10;
			// 
			// MaskedIdsParamsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxMask);
			this.Controls.Add(this.labelMask);
			this.Name = "MaskedIdsParamsControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(251, 40);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelMask;
		private System.Windows.Forms.TextBox textBoxMask;
	}
}