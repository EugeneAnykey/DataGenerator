﻿namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	partial class ConstantsParamsControl
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
			this.labelConstant = new System.Windows.Forms.Label();
			this.textBoxConstant = new System.Windows.Forms.TextBox();
			this.labelExample = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelConstant
			// 
			this.labelConstant.AutoSize = true;
			this.labelConstant.Location = new System.Drawing.Point(11, 11);
			this.labelConstant.Name = "labelConstant";
			this.labelConstant.Size = new System.Drawing.Size(52, 13);
			this.labelConstant.TabIndex = 11;
			this.labelConstant.Text = "Constant:";
			// 
			// textBoxConstant
			// 
			this.textBoxConstant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxConstant.Location = new System.Drawing.Point(69, 8);
			this.textBoxConstant.Name = "textBoxConstant";
			this.textBoxConstant.Size = new System.Drawing.Size(156, 20);
			this.textBoxConstant.TabIndex = 12;
			// 
			// labelExample
			// 
			this.labelExample.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelExample.Location = new System.Drawing.Point(234, 4);
			this.labelExample.Name = "labelExample";
			this.labelExample.Size = new System.Drawing.Size(13, 31);
			this.labelExample.TabIndex = 19;
			this.labelExample.Text = "…";
			this.labelExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ConstantsParamsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.textBoxConstant);
			this.Controls.Add(this.labelConstant);
			this.Name = "ConstantsParamsControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(251, 39);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelConstant;
		private System.Windows.Forms.TextBox textBoxConstant;
		private System.Windows.Forms.Label labelExample;
	}
}
