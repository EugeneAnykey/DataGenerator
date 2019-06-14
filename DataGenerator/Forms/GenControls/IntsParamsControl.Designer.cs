namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	partial class IntsParamsControl
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
			this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
			this.labelParamMax = new System.Windows.Forms.Label();
			this.labelParamMin = new System.Windows.Forms.Label();
			this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown2
			// 
			this.numericUpDownMax.Location = new System.Drawing.Point(69, 39);
			this.numericUpDownMax.Name = "numericUpDown2";
			this.numericUpDownMax.Size = new System.Drawing.Size(170, 20);
			this.numericUpDownMax.TabIndex = 11;
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
			// numericUpDown1
			// 
			this.numericUpDownMin.Location = new System.Drawing.Point(69, 7);
			this.numericUpDownMin.Name = "numericUpDown1";
			this.numericUpDownMin.Size = new System.Drawing.Size(170, 20);
			this.numericUpDownMin.TabIndex = 8;
			// 
			// IntsParamsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.numericUpDownMax);
			this.Controls.Add(this.labelParamMax);
			this.Controls.Add(this.labelParamMin);
			this.Controls.Add(this.numericUpDownMin);
			this.Name = "IntsParamsControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(251, 75);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numericUpDownMax;
		private System.Windows.Forms.Label labelParamMax;
		private System.Windows.Forms.Label labelParamMin;
		private System.Windows.Forms.NumericUpDown numericUpDownMin;
	}
}
