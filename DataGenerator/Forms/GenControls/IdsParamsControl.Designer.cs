namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
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
			this.labelExample = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDownStep
			// 
			this.numericUpDownStep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownStep.Location = new System.Drawing.Point(69, 39);
			this.numericUpDownStep.Name = "numericUpDownStep";
			this.numericUpDownStep.Size = new System.Drawing.Size(179, 20);
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
			this.numericUpDownStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDownStart.Location = new System.Drawing.Point(69, 7);
			this.numericUpDownStart.Name = "numericUpDownStart";
			this.numericUpDownStart.Size = new System.Drawing.Size(179, 20);
			this.numericUpDownStart.TabIndex = 8;
			// 
			// labelExample
			// 
			this.labelExample.Dock = System.Windows.Forms.DockStyle.Right;
			this.labelExample.Location = new System.Drawing.Point(254, 4);
			this.labelExample.Name = "labelExample";
			this.labelExample.Size = new System.Drawing.Size(13, 67);
			this.labelExample.TabIndex = 18;
			this.labelExample.Text = "…";
			this.labelExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IdsParamsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.numericUpDownStep);
			this.Controls.Add(this.labelParamStep);
			this.Controls.Add(this.labelParamStart);
			this.Controls.Add(this.numericUpDownStart);
			this.Name = "IdsParamsControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(271, 75);
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
		private System.Windows.Forms.Label labelExample;
	}
}
