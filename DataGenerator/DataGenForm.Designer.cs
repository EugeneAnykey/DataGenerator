namespace EugeneAnykey.Project.DataGenerator
{
	partial class DataGenForm
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGenForm));
			this.buttonGenFile = new System.Windows.Forms.Button();
			this.numericUpDownRows = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownColumns = new System.Windows.Forms.NumericUpDown();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.comboBoxRowsMult = new System.Windows.Forms.ComboBox();
			this.labelElapsed = new System.Windows.Forms.Label();
			this.labelRows = new System.Windows.Forms.Label();
			this.labelColumns = new System.Windows.Forms.Label();
			this.buttonAbout = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonGenFile
			// 
			this.buttonGenFile.Location = new System.Drawing.Point(45, 131);
			this.buttonGenFile.Name = "buttonGenFile";
			this.buttonGenFile.Size = new System.Drawing.Size(120, 23);
			this.buttonGenFile.TabIndex = 0;
			this.buttonGenFile.Text = "Generate file...";
			this.buttonGenFile.UseVisualStyleBackColor = true;
			this.buttonGenFile.Click += new System.EventHandler(this.ButtonGenFile_Click);
			// 
			// numericUpDownRows
			// 
			this.numericUpDownRows.Location = new System.Drawing.Point(45, 38);
			this.numericUpDownRows.Name = "numericUpDownRows";
			this.numericUpDownRows.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownRows.TabIndex = 2;
			// 
			// numericUpDownColumns
			// 
			this.numericUpDownColumns.Location = new System.Drawing.Point(45, 86);
			this.numericUpDownColumns.Name = "numericUpDownColumns";
			this.numericUpDownColumns.Size = new System.Drawing.Size(120, 20);
			this.numericUpDownColumns.TabIndex = 3;
			// 
			// comboBoxRowsMult
			// 
			this.comboBoxRowsMult.FormattingEnabled = true;
			this.comboBoxRowsMult.Items.AddRange(new object[] {
            " ",
            "k",
            "M"});
			this.comboBoxRowsMult.Location = new System.Drawing.Point(171, 38);
			this.comboBoxRowsMult.Name = "comboBoxRowsMult";
			this.comboBoxRowsMult.Size = new System.Drawing.Size(83, 21);
			this.comboBoxRowsMult.TabIndex = 4;
			// 
			// labelElapsed
			// 
			this.labelElapsed.AutoSize = true;
			this.labelElapsed.Location = new System.Drawing.Point(23, 172);
			this.labelElapsed.Name = "labelElapsed";
			this.labelElapsed.Size = new System.Drawing.Size(48, 13);
			this.labelElapsed.TabIndex = 5;
			this.labelElapsed.Text = "Elapsed:";
			// 
			// labelRows
			// 
			this.labelRows.AutoSize = true;
			this.labelRows.Location = new System.Drawing.Point(23, 22);
			this.labelRows.Name = "labelRows";
			this.labelRows.Size = new System.Drawing.Size(37, 13);
			this.labelRows.TabIndex = 6;
			this.labelRows.Text = "Rows:";
			// 
			// labelColumns
			// 
			this.labelColumns.AutoSize = true;
			this.labelColumns.Location = new System.Drawing.Point(23, 70);
			this.labelColumns.Name = "labelColumns";
			this.labelColumns.Size = new System.Drawing.Size(50, 13);
			this.labelColumns.TabIndex = 7;
			this.labelColumns.Text = "Columns:";
			// 
			// buttonAbout
			// 
			this.buttonAbout.Location = new System.Drawing.Point(246, 185);
			this.buttonAbout.Name = "buttonAbout";
			this.buttonAbout.Size = new System.Drawing.Size(26, 23);
			this.buttonAbout.TabIndex = 8;
			this.buttonAbout.Text = "?";
			this.buttonAbout.UseVisualStyleBackColor = true;
			// 
			// DataGenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 224);
			this.Controls.Add(this.buttonAbout);
			this.Controls.Add(this.labelColumns);
			this.Controls.Add(this.labelRows);
			this.Controls.Add(this.labelElapsed);
			this.Controls.Add(this.comboBoxRowsMult);
			this.Controls.Add(this.numericUpDownColumns);
			this.Controls.Add(this.numericUpDownRows);
			this.Controls.Add(this.buttonGenFile);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DataGenForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumns)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonGenFile;
		private System.Windows.Forms.NumericUpDown numericUpDownRows;
		private System.Windows.Forms.NumericUpDown numericUpDownColumns;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ComboBox comboBoxRowsMult;
		private System.Windows.Forms.Label labelElapsed;
		private System.Windows.Forms.Label labelRows;
		private System.Windows.Forms.Label labelColumns;
		private System.Windows.Forms.Button buttonAbout;
	}
}

