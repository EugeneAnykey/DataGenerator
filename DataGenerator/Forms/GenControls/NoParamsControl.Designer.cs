namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
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
			this.labelParamNothing = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelParamNothing
			// 
			this.labelParamNothing.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelParamNothing.Location = new System.Drawing.Point(4, 4);
			this.labelParamNothing.Name = "labelParamNothing";
			this.labelParamNothing.Size = new System.Drawing.Size(243, 31);
			this.labelParamNothing.TabIndex = 11;
			this.labelParamNothing.Text = "Empty";
			this.labelParamNothing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NoParamsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelParamNothing);
			this.Name = "NoParamsControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(251, 39);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelParamNothing;
	}
}
