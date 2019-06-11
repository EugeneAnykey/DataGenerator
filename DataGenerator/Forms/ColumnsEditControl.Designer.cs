namespace EugeneAnykey.Project.DataGenerator.Forms
{
	partial class ColumnsEditControl
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.labelCount = new System.Windows.Forms.Label();
			this.groupBoxFixedStrings = new System.Windows.Forms.GroupBox();
			this.fixedStringsParamsControl1 = new EugeneAnykey.Project.DataGenerator.Forms.FixedStringsParamsControl();
			this.groupBoxIdsParams = new System.Windows.Forms.GroupBox();
			this.idsParamsControl1 = new EugeneAnykey.Project.DataGenerator.Forms.IdsParamsControl();
			this.groupBoxDoublesParams = new System.Windows.Forms.GroupBox();
			this.doublesParamsControl1 = new EugeneAnykey.Project.DataGenerator.Forms.DoublesParamsControl();
			this.groupBoxIntsParams = new System.Windows.Forms.GroupBox();
			this.intsParamsControl1 = new EugeneAnykey.Project.DataGenerator.Forms.IntsParamsControl();
			this.noParamsControl1 = new EugeneAnykey.Project.DataGenerator.Forms.NoParamsControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelType = new System.Windows.Forms.Label();
			this.comboBoxType = new System.Windows.Forms.ComboBox();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBoxFixedStrings.SuspendLayout();
			this.groupBoxIdsParams.SuspendLayout();
			this.groupBoxDoublesParams.SuspendLayout();
			this.groupBoxIntsParams.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(4, 4);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listBox1);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			this.splitContainer1.Panel1.Controls.Add(this.labelCount);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Panel1MinSize = 150;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxFixedStrings);
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxIdsParams);
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxDoublesParams);
			this.splitContainer1.Panel2.Controls.Add(this.groupBoxIntsParams);
			this.splitContainer1.Panel2.Controls.Add(this.noParamsControl1);
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Size = new System.Drawing.Size(446, 656);
			this.splitContainer1.SplitterDistance = 150;
			this.splitContainer1.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(4, 17);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(142, 594);
			this.listBox1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonAdd);
			this.panel1.Controls.Add(this.buttonDown);
			this.panel1.Controls.Add(this.buttonUp);
			this.panel1.Controls.Add(this.buttonRemove);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(4, 611);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(142, 41);
			this.panel1.TabIndex = 2;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(108, 15);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(29, 23);
			this.buttonAdd.TabIndex = 3;
			this.buttonAdd.Text = "+";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// buttonDown
			// 
			this.buttonDown.Location = new System.Drawing.Point(73, 15);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(29, 23);
			this.buttonDown.TabIndex = 2;
			this.buttonDown.Text = "v";
			this.buttonDown.UseVisualStyleBackColor = true;
			// 
			// buttonUp
			// 
			this.buttonUp.Location = new System.Drawing.Point(38, 15);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(29, 23);
			this.buttonUp.TabIndex = 1;
			this.buttonUp.Text = "^";
			this.buttonUp.UseVisualStyleBackColor = true;
			// 
			// buttonRemove
			// 
			this.buttonRemove.Location = new System.Drawing.Point(3, 15);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(29, 23);
			this.buttonRemove.TabIndex = 0;
			this.buttonRemove.Text = "-";
			this.buttonRemove.UseVisualStyleBackColor = true;
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelCount.Location = new System.Drawing.Point(4, 4);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(47, 13);
			this.labelCount.TabIndex = 1;
			this.labelCount.Text = "Count: 0";
			// 
			// groupBoxFixedStrings
			// 
			this.groupBoxFixedStrings.Controls.Add(this.fixedStringsParamsControl1);
			this.groupBoxFixedStrings.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxFixedStrings.Location = new System.Drawing.Point(4, 440);
			this.groupBoxFixedStrings.Name = "groupBoxFixedStrings";
			this.groupBoxFixedStrings.Size = new System.Drawing.Size(284, 230);
			this.groupBoxFixedStrings.TabIndex = 12;
			this.groupBoxFixedStrings.TabStop = false;
			this.groupBoxFixedStrings.Text = "Fixed Strings Parameters";
			// 
			// fixedStringsParamsControl1
			// 
			this.fixedStringsParamsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fixedStringsParamsControl1.Location = new System.Drawing.Point(3, 16);
			this.fixedStringsParamsControl1.Name = "fixedStringsParamsControl1";
			this.fixedStringsParamsControl1.Padding = new System.Windows.Forms.Padding(4);
			this.fixedStringsParamsControl1.Size = new System.Drawing.Size(278, 211);
			this.fixedStringsParamsControl1.TabIndex = 0;
			this.fixedStringsParamsControl1.UseFixedStrings = false;
			// 
			// groupBoxIdsParams
			// 
			this.groupBoxIdsParams.Controls.Add(this.idsParamsControl1);
			this.groupBoxIdsParams.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxIdsParams.Location = new System.Drawing.Point(4, 353);
			this.groupBoxIdsParams.Name = "groupBoxIdsParams";
			this.groupBoxIdsParams.Size = new System.Drawing.Size(284, 87);
			this.groupBoxIdsParams.TabIndex = 11;
			this.groupBoxIdsParams.TabStop = false;
			this.groupBoxIdsParams.Text = "Ids Parameters";
			// 
			// idsParamsControl1
			// 
			this.idsParamsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.idsParamsControl1.Location = new System.Drawing.Point(3, 16);
			this.idsParamsControl1.Name = "idsParamsControl1";
			this.idsParamsControl1.Padding = new System.Windows.Forms.Padding(4);
			this.idsParamsControl1.Size = new System.Drawing.Size(278, 68);
			this.idsParamsControl1.TabIndex = 0;
			// 
			// groupBoxDoublesParams
			// 
			this.groupBoxDoublesParams.Controls.Add(this.doublesParamsControl1);
			this.groupBoxDoublesParams.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxDoublesParams.Location = new System.Drawing.Point(4, 230);
			this.groupBoxDoublesParams.Name = "groupBoxDoublesParams";
			this.groupBoxDoublesParams.Size = new System.Drawing.Size(284, 123);
			this.groupBoxDoublesParams.TabIndex = 4;
			this.groupBoxDoublesParams.TabStop = false;
			this.groupBoxDoublesParams.Text = "Doubles Gen Parameters";
			// 
			// doublesParamsControl1
			// 
			this.doublesParamsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.doublesParamsControl1.Location = new System.Drawing.Point(3, 16);
			this.doublesParamsControl1.Name = "doublesParamsControl1";
			this.doublesParamsControl1.Padding = new System.Windows.Forms.Padding(4);
			this.doublesParamsControl1.Size = new System.Drawing.Size(278, 104);
			this.doublesParamsControl1.TabIndex = 0;
			// 
			// groupBoxIntsParams
			// 
			this.groupBoxIntsParams.Controls.Add(this.intsParamsControl1);
			this.groupBoxIntsParams.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxIntsParams.Location = new System.Drawing.Point(4, 141);
			this.groupBoxIntsParams.Name = "groupBoxIntsParams";
			this.groupBoxIntsParams.Size = new System.Drawing.Size(284, 89);
			this.groupBoxIntsParams.TabIndex = 0;
			this.groupBoxIntsParams.TabStop = false;
			this.groupBoxIntsParams.Text = "Integers Parameters";
			// 
			// intsParamsControl1
			// 
			this.intsParamsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.intsParamsControl1.Location = new System.Drawing.Point(3, 16);
			this.intsParamsControl1.Name = "intsParamsControl1";
			this.intsParamsControl1.Padding = new System.Windows.Forms.Padding(4);
			this.intsParamsControl1.Size = new System.Drawing.Size(278, 70);
			this.intsParamsControl1.TabIndex = 13;
			// 
			// noParamsControl1
			// 
			this.noParamsControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.noParamsControl1.Location = new System.Drawing.Point(4, 82);
			this.noParamsControl1.Name = "noParamsControl1";
			this.noParamsControl1.Padding = new System.Windows.Forms.Padding(4);
			this.noParamsControl1.Size = new System.Drawing.Size(284, 59);
			this.noParamsControl1.TabIndex = 15;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.labelType);
			this.panel2.Controls.Add(this.comboBoxType);
			this.panel2.Controls.Add(this.labelName);
			this.panel2.Controls.Add(this.textBoxName);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(284, 78);
			this.panel2.TabIndex = 3;
			// 
			// labelType
			// 
			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(13, 42);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(34, 13);
			this.labelType.TabIndex = 6;
			this.labelType.Text = "Type:";
			// 
			// comboBoxType
			// 
			this.comboBoxType.FormattingEnabled = true;
			this.comboBoxType.Location = new System.Drawing.Point(72, 39);
			this.comboBoxType.Name = "comboBoxType";
			this.comboBoxType.Size = new System.Drawing.Size(170, 21);
			this.comboBoxType.TabIndex = 5;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(13, 16);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(38, 13);
			this.labelName.TabIndex = 4;
			this.labelName.Text = "Name:";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(72, 13);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(170, 20);
			this.textBoxName.TabIndex = 3;
			// 
			// ColumnsEditControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "ColumnsEditControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(454, 664);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBoxFixedStrings.ResumeLayout(false);
			this.groupBoxIdsParams.ResumeLayout(false);
			this.groupBoxDoublesParams.ResumeLayout(false);
			this.groupBoxIntsParams.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.GroupBox groupBoxIntsParams;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.ComboBox comboBoxType;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.GroupBox groupBoxDoublesParams;
		private System.Windows.Forms.GroupBox groupBoxIdsParams;
		private IntsParamsControl intsParamsControl1;
		private IdsParamsControl idsParamsControl1;
		private DoublesParamsControl doublesParamsControl1;
		private System.Windows.Forms.GroupBox groupBoxFixedStrings;
		private FixedStringsParamsControl fixedStringsParamsControl1;
		private NoParamsControl noParamsControl1;
	}
}
