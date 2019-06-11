namespace EugeneAnykey.Project.DataGenerator.Forms
{
	partial class NoParamsControl
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
			this.groupBoxParams = new System.Windows.Forms.GroupBox();
			this.labelParamNothing = new System.Windows.Forms.Label();
			this.groupBoxParams.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxParams
			// 
			this.groupBoxParams.Controls.Add(this.labelParamNothing);
			this.groupBoxParams.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxParams.Location = new System.Drawing.Point(4, 4);
			this.groupBoxParams.Name = "groupBoxParams";
			this.groupBoxParams.Size = new System.Drawing.Size(243, 51);
			this.groupBoxParams.TabIndex = 10;
			this.groupBoxParams.TabStop = false;
			this.groupBoxParams.Text = "Parameters:";
			// 
			// labelParamNothing
			// 
			this.labelParamNothing.AutoSize = true;
			this.labelParamNothing.Location = new System.Drawing.Point(86, 25);
			this.labelParamNothing.Name = "labelParamNothing";
			this.labelParamNothing.Size = new System.Drawing.Size(76, 13);
			this.labelParamNothing.TabIndex = 10;
			this.labelParamNothing.Text = "No parameters";
			// 
			// NoParamsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxParams);
			this.Name = "NoParamsControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(251, 59);
			this.groupBoxParams.ResumeLayout(false);
			this.groupBoxParams.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxParams;
		private System.Windows.Forms.Label labelParamNothing;
	}
}
