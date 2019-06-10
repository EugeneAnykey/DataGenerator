namespace EugeneAnykey.Project.DataGenerator.Forms
{
	partial class IdsParamsControl
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
			this.numericUpDownStep = new System.Windows.Forms.NumericUpDown();
			this.labelParamStep = new System.Windows.Forms.Label();
			this.labelParamStart = new System.Windows.Forms.Label();
			this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDownStep
			// 
			this.numericUpDownStep.Location = new System.Drawing.Point(69, 39);
			this.numericUpDownStep.Name = "numericUpDownStep";
			this.numericUpDownStep.Size = new System.Drawing.Size(170, 20);
			this.numericUpDownStep.TabIndex = 11;
			// 
			// labelParamStep
			// 
			this.labelParamStep.AutoSize = true;
			this.labelParamStep.Location = new System.Drawing.Point(10, 41);
			this.labelParamStep.Name = "labelParamStep";
			this.labelParamStep.Size = new System.Drawing.Size(32, 13);
			this.labelParamStep.TabIndex = 10;
			this.labelParamStep.Text = "Step:";
			// 
			// labelParamStart
			// 
			this.labelParamStart.AutoSize = true;
			this.labelParamStart.Location = new System.Drawing.Point(10, 9);
			this.labelParamStart.Name = "labelParamStart";
			this.labelParamStart.Size = new System.Drawing.Size(32, 13);
			this.labelParamStart.TabIndex = 9;
			this.labelParamStart.Text = "Start:";
			// 
			// numericUpDownStart
			// 
			this.numericUpDownStart.Location = new System.Drawing.Point(69, 7);
			this.numericUpDownStart.Name = "numericUpDownStart";
			this.numericUpDownStart.Size = new System.Drawing.Size(170, 20);
			this.numericUpDownStart.TabIndex = 8;
			// 
			// IdsParamsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.numericUpDownStep);
			this.Controls.Add(this.labelParamStep);
			this.Controls.Add(this.labelParamStart);
			this.Controls.Add(this.numericUpDownStart);
			this.Name = "IdsParamsControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(251, 75);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numericUpDownStep;
		private System.Windows.Forms.Label labelParamStep;
		private System.Windows.Forms.Label labelParamStart;
		private System.Windows.Forms.NumericUpDown numericUpDownStart;
	}
}
