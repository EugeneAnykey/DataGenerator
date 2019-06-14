namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	partial class DatesParamsControl
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
			this.labelParamMax = new System.Windows.Forms.Label();
			this.labelParamMin = new System.Windows.Forms.Label();
			this.dateTimePickerMin = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerMax = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// labelParamMax
			// 
			this.labelParamMax.AutoSize = true;
			this.labelParamMax.Location = new System.Drawing.Point(10, 41);
			this.labelParamMax.Name = "labelParamMax";
			this.labelParamMax.Size = new System.Drawing.Size(30, 13);
			this.labelParamMax.TabIndex = 10;
			this.labelParamMax.Text = "Max:";
			// 
			// labelParamMin
			// 
			this.labelParamMin.AutoSize = true;
			this.labelParamMin.Location = new System.Drawing.Point(10, 9);
			this.labelParamMin.Name = "labelParamMin";
			this.labelParamMin.Size = new System.Drawing.Size(27, 13);
			this.labelParamMin.TabIndex = 9;
			this.labelParamMin.Text = "Min:";
			// 
			// dateTimePickerMin
			// 
			this.dateTimePickerMin.Location = new System.Drawing.Point(64, 3);
			this.dateTimePickerMin.Name = "dateTimePickerMin";
			this.dateTimePickerMin.Size = new System.Drawing.Size(180, 20);
			this.dateTimePickerMin.TabIndex = 11;
			// 
			// dateTimePickerMax
			// 
			this.dateTimePickerMax.Location = new System.Drawing.Point(64, 35);
			this.dateTimePickerMax.Name = "dateTimePickerMax";
			this.dateTimePickerMax.Size = new System.Drawing.Size(180, 20);
			this.dateTimePickerMax.TabIndex = 12;
			// 
			// DatesParamsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dateTimePickerMax);
			this.Controls.Add(this.dateTimePickerMin);
			this.Controls.Add(this.labelParamMax);
			this.Controls.Add(this.labelParamMin);
			this.Name = "DatesParamsControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(251, 66);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label labelParamMax;
		private System.Windows.Forms.Label labelParamMin;
		private System.Windows.Forms.DateTimePicker dateTimePickerMin;
		private System.Windows.Forms.DateTimePicker dateTimePickerMax;
	}
}
