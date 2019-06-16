namespace EugeneAnykey.Project.DataGenerator.Forms
{
	partial class RowsCountControl
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
			this.groupBoxRows = new System.Windows.Forms.GroupBox();
			this.buttonMult = new EugeneAnykey.Forms.Controls.SequenceButton();
			this.buttonGenFile = new System.Windows.Forms.Button();
			this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
			this.groupBoxRows.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxRows
			// 
			this.groupBoxRows.Controls.Add(this.buttonMult);
			this.groupBoxRows.Controls.Add(this.buttonGenFile);
			this.groupBoxRows.Controls.Add(this.numericUpDownRows);
			this.groupBoxRows.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxRows.Location = new System.Drawing.Point(4, 4);
			this.groupBoxRows.Name = "groupBoxRows";
			this.groupBoxRows.Size = new System.Drawing.Size(382, 50);
			this.groupBoxRows.TabIndex = 10;
			this.groupBoxRows.TabStop = false;
			this.groupBoxRows.Text = "Rows:";
			// 
			// buttonMult
			// 
			this.buttonMult.Location = new System.Drawing.Point(148, 16);
			this.buttonMult.Name = "buttonMult";
			this.buttonMult.Size = new System.Drawing.Size(31, 23);
			this.buttonMult.TabIndex = 16;
			this.buttonMult.Text = "undefinite";
			this.buttonMult.UndefiniteState = false;
			this.buttonMult.UseVisualStyleBackColor = true;
			this.buttonMult.ValuePosition = 0;
			this.buttonMult.Values = new string[0];
			// 
			// buttonGenFile
			// 
			this.buttonGenFile.Location = new System.Drawing.Point(256, 16);
			this.buttonGenFile.Name = "buttonGenFile";
			this.buttonGenFile.Size = new System.Drawing.Size(120, 23);
			this.buttonGenFile.TabIndex = 12;
			this.buttonGenFile.Text = "Generate file...";
			this.buttonGenFile.UseVisualStyleBackColor = true;
			// 
			// numericUpDownRows
			// 
			this.numericUpDownRows.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericUpDownRows.Location = new System.Drawing.Point(22, 19);
			this.numericUpDownRows.Name = "numericUpDownRows";
			this.numericUpDownRows.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownRows.TabIndex = 10;
			// 
			// RowsCountControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxRows);
			this.Name = "RowsCountControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(390, 58);
			this.groupBoxRows.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxRows;
		private System.Windows.Forms.NumericUpDown numericUpDownRows;
		private System.Windows.Forms.Button buttonGenFile;
		private EugeneAnykey.Forms.Controls.SequenceButton buttonMult;
	}
}
