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
			this.comboBoxRowsMult = new System.Windows.Forms.ComboBox();
			this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
			this.groupBoxRows.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxRows
			// 
			this.groupBoxRows.Controls.Add(this.comboBoxRowsMult);
			this.groupBoxRows.Controls.Add(this.numericUpDownRows);
			this.groupBoxRows.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxRows.Location = new System.Drawing.Point(4, 4);
			this.groupBoxRows.Name = "groupBoxRows";
			this.groupBoxRows.Size = new System.Drawing.Size(243, 50);
			this.groupBoxRows.TabIndex = 10;
			this.groupBoxRows.TabStop = false;
			this.groupBoxRows.Text = "Rows:";
			// 
			// comboBoxRowsMult
			// 
			this.comboBoxRowsMult.FormattingEnabled = true;
			this.comboBoxRowsMult.Items.AddRange(new object[] {
            " ",
            "k",
            "M"});
			this.comboBoxRowsMult.Location = new System.Drawing.Point(157, 19);
			this.comboBoxRowsMult.Name = "comboBoxRowsMult";
			this.comboBoxRowsMult.Size = new System.Drawing.Size(54, 21);
			this.comboBoxRowsMult.TabIndex = 11;
			// 
			// numericUpDownRows
			// 
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
			this.Size = new System.Drawing.Size(251, 58);
			this.groupBoxRows.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxRows;
		private System.Windows.Forms.ComboBox comboBoxRowsMult;
		private System.Windows.Forms.NumericUpDown numericUpDownRows;
	}
}
