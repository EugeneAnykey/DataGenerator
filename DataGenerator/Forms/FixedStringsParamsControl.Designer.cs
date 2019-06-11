namespace EugeneAnykey.Project.DataGenerator.Forms
{
	partial class FixedStringsParamsControl
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
			this.groupBoxItems = new System.Windows.Forms.GroupBox();
			this.textBoxItems = new System.Windows.Forms.TextBox();
			this.panelSeparators = new System.Windows.Forms.Panel();
			this.buttonFastExample = new System.Windows.Forms.Button();
			this.comboBoxItemsSeparator = new System.Windows.Forms.ComboBox();
			this.labelItemsSeparator = new System.Windows.Forms.Label();
			this.panelMaxLength = new System.Windows.Forms.Panel();
			this.labelParamFixed = new System.Windows.Forms.Label();
			this.numericUpDownFixed = new System.Windows.Forms.NumericUpDown();
			this.labelName = new System.Windows.Forms.Label();
			this.groupBoxParams.SuspendLayout();
			this.groupBoxItems.SuspendLayout();
			this.panelSeparators.SuspendLayout();
			this.panelMaxLength.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFixed)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxParams
			// 
			this.groupBoxParams.Controls.Add(this.groupBoxItems);
			this.groupBoxParams.Controls.Add(this.panelSeparators);
			this.groupBoxParams.Controls.Add(this.panelMaxLength);
			this.groupBoxParams.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxParams.Location = new System.Drawing.Point(4, 17);
			this.groupBoxParams.Name = "groupBoxParams";
			this.groupBoxParams.Size = new System.Drawing.Size(263, 226);
			this.groupBoxParams.TabIndex = 13;
			this.groupBoxParams.TabStop = false;
			// 
			// groupBoxItems
			// 
			this.groupBoxItems.Controls.Add(this.textBoxItems);
			this.groupBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxItems.Location = new System.Drawing.Point(3, 124);
			this.groupBoxItems.Name = "groupBoxItems";
			this.groupBoxItems.Size = new System.Drawing.Size(257, 99);
			this.groupBoxItems.TabIndex = 14;
			this.groupBoxItems.TabStop = false;
			this.groupBoxItems.Text = "Items:";
			// 
			// textBoxItems
			// 
			this.textBoxItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxItems.Location = new System.Drawing.Point(3, 16);
			this.textBoxItems.Multiline = true;
			this.textBoxItems.Name = "textBoxItems";
			this.textBoxItems.Size = new System.Drawing.Size(251, 80);
			this.textBoxItems.TabIndex = 3;
			// 
			// panelSeparators
			// 
			this.panelSeparators.Controls.Add(this.buttonFastExample);
			this.panelSeparators.Controls.Add(this.comboBoxItemsSeparator);
			this.panelSeparators.Controls.Add(this.labelItemsSeparator);
			this.panelSeparators.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelSeparators.Location = new System.Drawing.Point(3, 56);
			this.panelSeparators.Name = "panelSeparators";
			this.panelSeparators.Size = new System.Drawing.Size(257, 68);
			this.panelSeparators.TabIndex = 13;
			// 
			// buttonFastExample
			// 
			this.buttonFastExample.Location = new System.Drawing.Point(115, 36);
			this.buttonFastExample.Name = "buttonFastExample";
			this.buttonFastExample.Size = new System.Drawing.Size(125, 23);
			this.buttonFastExample.TabIndex = 10;
			this.buttonFastExample.Text = "Fast Example";
			this.buttonFastExample.UseVisualStyleBackColor = true;
			// 
			// comboBoxItemsSeparator
			// 
			this.comboBoxItemsSeparator.FormattingEnabled = true;
			this.comboBoxItemsSeparator.Location = new System.Drawing.Point(115, 9);
			this.comboBoxItemsSeparator.Name = "comboBoxItemsSeparator";
			this.comboBoxItemsSeparator.Size = new System.Drawing.Size(125, 21);
			this.comboBoxItemsSeparator.TabIndex = 9;
			// 
			// labelItemsSeparator
			// 
			this.labelItemsSeparator.AutoSize = true;
			this.labelItemsSeparator.Location = new System.Drawing.Point(11, 12);
			this.labelItemsSeparator.Name = "labelItemsSeparator";
			this.labelItemsSeparator.Size = new System.Drawing.Size(84, 13);
			this.labelItemsSeparator.TabIndex = 8;
			this.labelItemsSeparator.Text = "Items Separator:";
			// 
			// panelMaxLength
			// 
			this.panelMaxLength.Controls.Add(this.labelParamFixed);
			this.panelMaxLength.Controls.Add(this.numericUpDownFixed);
			this.panelMaxLength.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMaxLength.Location = new System.Drawing.Point(3, 16);
			this.panelMaxLength.Name = "panelMaxLength";
			this.panelMaxLength.Size = new System.Drawing.Size(257, 40);
			this.panelMaxLength.TabIndex = 11;
			// 
			// labelParamFixed
			// 
			this.labelParamFixed.AutoSize = true;
			this.labelParamFixed.Location = new System.Drawing.Point(11, 16);
			this.labelParamFixed.Name = "labelParamFixed";
			this.labelParamFixed.Size = new System.Drawing.Size(66, 13);
			this.labelParamFixed.TabIndex = 11;
			this.labelParamFixed.Text = "Max Length:";
			// 
			// numericUpDownFixed
			// 
			this.numericUpDownFixed.Location = new System.Drawing.Point(115, 14);
			this.numericUpDownFixed.Name = "numericUpDownFixed";
			this.numericUpDownFixed.Size = new System.Drawing.Size(125, 20);
			this.numericUpDownFixed.TabIndex = 10;
			// 
			// labelName
			// 
			this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelName.Location = new System.Drawing.Point(4, 4);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(263, 13);
			this.labelName.TabIndex = 14;
			this.labelName.Text = "Name";
			// 
			// FixedStringsParamsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxParams);
			this.Controls.Add(this.labelName);
			this.Name = "FixedStringsParamsControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(271, 247);
			this.groupBoxParams.ResumeLayout(false);
			this.groupBoxItems.ResumeLayout(false);
			this.groupBoxItems.PerformLayout();
			this.panelSeparators.ResumeLayout(false);
			this.panelSeparators.PerformLayout();
			this.panelMaxLength.ResumeLayout(false);
			this.panelMaxLength.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFixed)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxParams;
		private System.Windows.Forms.GroupBox groupBoxItems;
		private System.Windows.Forms.TextBox textBoxItems;
		private System.Windows.Forms.Panel panelSeparators;
		private System.Windows.Forms.Button buttonFastExample;
		private System.Windows.Forms.ComboBox comboBoxItemsSeparator;
		private System.Windows.Forms.Label labelItemsSeparator;
		private System.Windows.Forms.Panel panelMaxLength;
		private System.Windows.Forms.Label labelParamFixed;
		private System.Windows.Forms.NumericUpDown numericUpDownFixed;
		private System.Windows.Forms.Label labelName;
	}
}
