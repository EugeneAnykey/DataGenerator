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
			this.collapsableStringsParams = new EugeneAnykey.Forms.Controls.CollapsableControl();
			this.fixedStringsParamsControl1 = new EugeneAnykey.Project.DataGenerator.Forms.LimitedStringsParamsControl();
			this.checkBoxLimitedStrings = new System.Windows.Forms.CheckBox();
			this.collapsableDoublesParams = new EugeneAnykey.Forms.Controls.CollapsableControl();
			this.doublesParamsControl1 = new EugeneAnykey.Project.DataGenerator.Forms.DoublesParamsControl();
			this.collapsableIntsParams = new EugeneAnykey.Forms.Controls.CollapsableControl();
			this.intsParamsControl1 = new EugeneAnykey.Project.DataGenerator.Forms.IntsParamsControl();
			this.collapsableIdsParams = new EugeneAnykey.Forms.Controls.CollapsableControl();
			this.doublesParamsControl2 = new EugeneAnykey.Project.DataGenerator.Forms.DoublesParamsControl();
			this.idsParamsControl1 = new EugeneAnykey.Project.DataGenerator.Forms.IdsParamsControl();
			this.collapsableNoParams = new EugeneAnykey.Forms.Controls.CollapsableControl();
			this.noParamsControl1 = new EugeneAnykey.Project.DataGenerator.Forms.NoParamsControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.collapsableStringsParams.WorkingArea.SuspendLayout();
			this.collapsableStringsParams.SuspendLayout();
			this.collapsableDoublesParams.WorkingArea.SuspendLayout();
			this.collapsableDoublesParams.SuspendLayout();
			this.collapsableIntsParams.WorkingArea.SuspendLayout();
			this.collapsableIntsParams.SuspendLayout();
			this.collapsableIdsParams.WorkingArea.SuspendLayout();
			this.collapsableIdsParams.SuspendLayout();
			this.collapsableNoParams.WorkingArea.SuspendLayout();
			this.collapsableNoParams.SuspendLayout();
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
			this.splitContainer1.Panel2.Controls.Add(this.collapsableStringsParams);
			this.splitContainer1.Panel2.Controls.Add(this.collapsableDoublesParams);
			this.splitContainer1.Panel2.Controls.Add(this.collapsableIntsParams);
			this.splitContainer1.Panel2.Controls.Add(this.collapsableIdsParams);
			this.splitContainer1.Panel2.Controls.Add(this.collapsableNoParams);
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
			// collapsableStringsParams
			// 
			this.collapsableStringsParams.AllowDrop = true;
			this.collapsableStringsParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.collapsableStringsParams.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.collapsableStringsParams.Caption = "Strings Parameters";
			this.collapsableStringsParams.CaptionCollapsed = "";
			this.collapsableStringsParams.CaptionOppositeAlignment = false;
			this.collapsableStringsParams.Collapsable = true;
			this.collapsableStringsParams.Collapsed = false;
			this.collapsableStringsParams.ControlOrientation = System.Windows.Forms.Orientation.Horizontal;
			this.collapsableStringsParams.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsableStringsParams.Location = new System.Drawing.Point(4, 157);
			this.collapsableStringsParams.Name = "collapsableStringsParams";
			this.collapsableStringsParams.Padding = new System.Windows.Forms.Padding(4);
			this.collapsableStringsParams.Size = new System.Drawing.Size(284, 313);
			this.collapsableStringsParams.TabIndex = 19;
			// 
			// collapsableStringsParams.WorkingArea
			// 
			this.collapsableStringsParams.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.collapsableStringsParams.WorkingArea.Controls.Add(this.fixedStringsParamsControl1);
			this.collapsableStringsParams.WorkingArea.Controls.Add(this.checkBoxLimitedStrings);
			this.collapsableStringsParams.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collapsableStringsParams.WorkingArea.Location = new System.Drawing.Point(4, 18);
			this.collapsableStringsParams.WorkingArea.Name = "WorkingArea";
			this.collapsableStringsParams.WorkingArea.Size = new System.Drawing.Size(276, 291);
			this.collapsableStringsParams.WorkingArea.TabIndex = 2;
			// 
			// fixedStringsParamsControl1
			// 
			this.fixedStringsParamsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fixedStringsParamsControl1.Location = new System.Drawing.Point(0, 17);
			this.fixedStringsParamsControl1.Name = "fixedStringsParamsControl1";
			this.fixedStringsParamsControl1.Padding = new System.Windows.Forms.Padding(4);
			this.fixedStringsParamsControl1.Size = new System.Drawing.Size(276, 274);
			this.fixedStringsParamsControl1.TabIndex = 1;
			this.fixedStringsParamsControl1.UseLimitedStrings = false;
			// 
			// checkBoxLimitedStrings
			// 
			this.checkBoxLimitedStrings.AutoSize = true;
			this.checkBoxLimitedStrings.Dock = System.Windows.Forms.DockStyle.Top;
			this.checkBoxLimitedStrings.Location = new System.Drawing.Point(0, 0);
			this.checkBoxLimitedStrings.Name = "checkBoxLimitedStrings";
			this.checkBoxLimitedStrings.Size = new System.Drawing.Size(276, 17);
			this.checkBoxLimitedStrings.TabIndex = 2;
			this.checkBoxLimitedStrings.Text = "Limited Strings";
			this.checkBoxLimitedStrings.UseVisualStyleBackColor = true;
			// 
			// collapsableDoublesParams
			// 
			this.collapsableDoublesParams.AllowDrop = true;
			this.collapsableDoublesParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.collapsableDoublesParams.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.collapsableDoublesParams.Caption = "Doubles Parameters";
			this.collapsableDoublesParams.CaptionCollapsed = "";
			this.collapsableDoublesParams.CaptionOppositeAlignment = false;
			this.collapsableDoublesParams.Collapsable = true;
			this.collapsableDoublesParams.Collapsed = true;
			this.collapsableDoublesParams.ControlOrientation = System.Windows.Forms.Orientation.Horizontal;
			this.collapsableDoublesParams.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsableDoublesParams.Location = new System.Drawing.Point(4, 135);
			this.collapsableDoublesParams.Name = "collapsableDoublesParams";
			this.collapsableDoublesParams.Padding = new System.Windows.Forms.Padding(4);
			this.collapsableDoublesParams.Size = new System.Drawing.Size(284, 22);
			this.collapsableDoublesParams.TabIndex = 22;
			// 
			// collapsableDoublesParams.WorkingArea
			// 
			this.collapsableDoublesParams.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.collapsableDoublesParams.WorkingArea.Controls.Add(this.doublesParamsControl1);
			this.collapsableDoublesParams.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collapsableDoublesParams.WorkingArea.Location = new System.Drawing.Point(4, 18);
			this.collapsableDoublesParams.WorkingArea.Name = "WorkingArea";
			this.collapsableDoublesParams.WorkingArea.Size = new System.Drawing.Size(276, 101);
			this.collapsableDoublesParams.WorkingArea.TabIndex = 2;
			// 
			// doublesParamsControl1
			// 
			this.doublesParamsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.doublesParamsControl1.Location = new System.Drawing.Point(0, 0);
			this.doublesParamsControl1.Name = "doublesParamsControl1";
			this.doublesParamsControl1.Padding = new System.Windows.Forms.Padding(4);
			this.doublesParamsControl1.Size = new System.Drawing.Size(276, 101);
			this.doublesParamsControl1.TabIndex = 1;
			// 
			// collapsableIntsParams
			// 
			this.collapsableIntsParams.AllowDrop = true;
			this.collapsableIntsParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.collapsableIntsParams.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.collapsableIntsParams.Caption = "Integers Parameters";
			this.collapsableIntsParams.CaptionCollapsed = "";
			this.collapsableIntsParams.CaptionOppositeAlignment = false;
			this.collapsableIntsParams.Collapsable = true;
			this.collapsableIntsParams.Collapsed = true;
			this.collapsableIntsParams.ControlOrientation = System.Windows.Forms.Orientation.Horizontal;
			this.collapsableIntsParams.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsableIntsParams.Location = new System.Drawing.Point(4, 113);
			this.collapsableIntsParams.Name = "collapsableIntsParams";
			this.collapsableIntsParams.Padding = new System.Windows.Forms.Padding(4);
			this.collapsableIntsParams.Size = new System.Drawing.Size(284, 22);
			this.collapsableIntsParams.TabIndex = 20;
			// 
			// collapsableIntsParams.WorkingArea
			// 
			this.collapsableIntsParams.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.collapsableIntsParams.WorkingArea.Controls.Add(this.intsParamsControl1);
			this.collapsableIntsParams.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collapsableIntsParams.WorkingArea.Location = new System.Drawing.Point(4, 18);
			this.collapsableIntsParams.WorkingArea.Name = "WorkingArea";
			this.collapsableIntsParams.WorkingArea.Size = new System.Drawing.Size(276, 66);
			this.collapsableIntsParams.WorkingArea.TabIndex = 2;
			// 
			// intsParamsControl1
			// 
			this.intsParamsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.intsParamsControl1.Location = new System.Drawing.Point(0, 0);
			this.intsParamsControl1.Name = "intsParamsControl1";
			this.intsParamsControl1.Padding = new System.Windows.Forms.Padding(4);
			this.intsParamsControl1.Size = new System.Drawing.Size(276, 66);
			this.intsParamsControl1.TabIndex = 14;
			// 
			// collapsableIdsParams
			// 
			this.collapsableIdsParams.AllowDrop = true;
			this.collapsableIdsParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.collapsableIdsParams.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.collapsableIdsParams.Caption = "Ids Parameters";
			this.collapsableIdsParams.CaptionCollapsed = "";
			this.collapsableIdsParams.CaptionOppositeAlignment = false;
			this.collapsableIdsParams.Collapsable = true;
			this.collapsableIdsParams.Collapsed = true;
			this.collapsableIdsParams.ControlOrientation = System.Windows.Forms.Orientation.Horizontal;
			this.collapsableIdsParams.Controls.Add(this.doublesParamsControl2);
			this.collapsableIdsParams.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsableIdsParams.Location = new System.Drawing.Point(4, 91);
			this.collapsableIdsParams.Name = "collapsableIdsParams";
			this.collapsableIdsParams.Padding = new System.Windows.Forms.Padding(4);
			this.collapsableIdsParams.Size = new System.Drawing.Size(284, 22);
			this.collapsableIdsParams.TabIndex = 17;
			// 
			// collapsableIdsParams.WorkingArea
			// 
			this.collapsableIdsParams.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.collapsableIdsParams.WorkingArea.Controls.Add(this.idsParamsControl1);
			this.collapsableIdsParams.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collapsableIdsParams.WorkingArea.Location = new System.Drawing.Point(4, 18);
			this.collapsableIdsParams.WorkingArea.Name = "WorkingArea";
			this.collapsableIdsParams.WorkingArea.Size = new System.Drawing.Size(276, 69);
			this.collapsableIdsParams.WorkingArea.TabIndex = 2;
			// 
			// doublesParamsControl2
			// 
			this.doublesParamsControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.doublesParamsControl2.Location = new System.Drawing.Point(4, 4);
			this.doublesParamsControl2.Name = "doublesParamsControl2";
			this.doublesParamsControl2.Padding = new System.Windows.Forms.Padding(4);
			this.doublesParamsControl2.Size = new System.Drawing.Size(276, 14);
			this.doublesParamsControl2.TabIndex = 4;
			// 
			// idsParamsControl1
			// 
			this.idsParamsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.idsParamsControl1.Location = new System.Drawing.Point(0, 0);
			this.idsParamsControl1.Name = "idsParamsControl1";
			this.idsParamsControl1.Padding = new System.Windows.Forms.Padding(4);
			this.idsParamsControl1.Size = new System.Drawing.Size(276, 69);
			this.idsParamsControl1.TabIndex = 1;
			// 
			// collapsableNoParams
			// 
			this.collapsableNoParams.AllowDrop = true;
			this.collapsableNoParams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.collapsableNoParams.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.collapsableNoParams.Caption = "No Parameters";
			this.collapsableNoParams.CaptionCollapsed = "";
			this.collapsableNoParams.CaptionOppositeAlignment = false;
			this.collapsableNoParams.Collapsable = true;
			this.collapsableNoParams.Collapsed = false;
			this.collapsableNoParams.ControlOrientation = System.Windows.Forms.Orientation.Horizontal;
			this.collapsableNoParams.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsableNoParams.Location = new System.Drawing.Point(4, 47);
			this.collapsableNoParams.Name = "collapsableNoParams";
			this.collapsableNoParams.Padding = new System.Windows.Forms.Padding(4);
			this.collapsableNoParams.Size = new System.Drawing.Size(284, 44);
			this.collapsableNoParams.TabIndex = 21;
			// 
			// collapsableNoParams.WorkingArea
			// 
			this.collapsableNoParams.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.collapsableNoParams.WorkingArea.Controls.Add(this.noParamsControl1);
			this.collapsableNoParams.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collapsableNoParams.WorkingArea.Location = new System.Drawing.Point(4, 18);
			this.collapsableNoParams.WorkingArea.Name = "WorkingArea";
			this.collapsableNoParams.WorkingArea.Size = new System.Drawing.Size(276, 22);
			this.collapsableNoParams.WorkingArea.TabIndex = 2;
			// 
			// noParamsControl1
			// 
			this.noParamsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.noParamsControl1.Location = new System.Drawing.Point(0, 0);
			this.noParamsControl1.Name = "noParamsControl1";
			this.noParamsControl1.Padding = new System.Windows.Forms.Padding(4);
			this.noParamsControl1.Size = new System.Drawing.Size(276, 22);
			this.noParamsControl1.TabIndex = 16;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.labelName);
			this.panel2.Controls.Add(this.textBoxName);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(284, 43);
			this.panel2.TabIndex = 3;
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
			this.collapsableStringsParams.WorkingArea.ResumeLayout(false);
			this.collapsableStringsParams.WorkingArea.PerformLayout();
			this.collapsableStringsParams.ResumeLayout(false);
			this.collapsableDoublesParams.WorkingArea.ResumeLayout(false);
			this.collapsableDoublesParams.ResumeLayout(false);
			this.collapsableIntsParams.WorkingArea.ResumeLayout(false);
			this.collapsableIntsParams.ResumeLayout(false);
			this.collapsableIdsParams.WorkingArea.ResumeLayout(false);
			this.collapsableIdsParams.ResumeLayout(false);
			this.collapsableNoParams.WorkingArea.ResumeLayout(false);
			this.collapsableNoParams.ResumeLayout(false);
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
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private EugeneAnykey.Forms.Controls.CollapsableControl collapsableIdsParams;
		private DoublesParamsControl doublesParamsControl2;
		private IdsParamsControl idsParamsControl1;
		private EugeneAnykey.Forms.Controls.CollapsableControl collapsableStringsParams;
		private LimitedStringsParamsControl fixedStringsParamsControl1;
		private EugeneAnykey.Forms.Controls.CollapsableControl collapsableDoublesParams;
		private DoublesParamsControl doublesParamsControl1;
		private EugeneAnykey.Forms.Controls.CollapsableControl collapsableIntsParams;
		private IntsParamsControl intsParamsControl1;
		private EugeneAnykey.Forms.Controls.CollapsableControl collapsableNoParams;
		private NoParamsControl noParamsControl1;
		private System.Windows.Forms.CheckBox checkBoxLimitedStrings;
	}
}
