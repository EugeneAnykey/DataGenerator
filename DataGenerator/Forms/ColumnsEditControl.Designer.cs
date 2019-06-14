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
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.gensListControl1 = new EugeneAnykey.Project.DataGenerator.Forms.GensListControl();
			this.collapsableStringsParams = new EugeneAnykey.Forms.Controls.CollapsableControl();
			this.stringsParamsControl = new EugeneAnykey.Project.DataGenerator.Forms.GenControls.LimitedStringsParamsControl();
			this.checkBoxLimitedStrings = new System.Windows.Forms.CheckBox();
			this.collapsableDates = new EugeneAnykey.Forms.Controls.CollapsableControl();
			this.collapsableDoublesParams = new EugeneAnykey.Forms.Controls.CollapsableControl();
			this.doublesParamsControl = new EugeneAnykey.Project.DataGenerator.Forms.GenControls.DoublesParamsControl();
			this.collapsableIntsParams = new EugeneAnykey.Forms.Controls.CollapsableControl();
			this.intsParamsControl = new EugeneAnykey.Project.DataGenerator.Forms.GenControls.IntsParamsControl();
			this.collapsableIdsParams = new EugeneAnykey.Forms.Controls.CollapsableControl();
			this.idsParamsControl = new EugeneAnykey.Project.DataGenerator.Forms.GenControls.IdsParamsControl();
			this.collapsableNoParams = new EugeneAnykey.Forms.Controls.CollapsableControl();
			this.noParamsControl = new EugeneAnykey.Project.DataGenerator.Forms.GenControls.NoParamsControl();
			this.datesParamsControl = new EugeneAnykey.Project.DataGenerator.Forms.GenControls.DatesParamsControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.collapsableStringsParams.WorkingArea.SuspendLayout();
			this.collapsableStringsParams.SuspendLayout();
			this.collapsableDates.WorkingArea.SuspendLayout();
			this.collapsableDates.SuspendLayout();
			this.collapsableDoublesParams.WorkingArea.SuspendLayout();
			this.collapsableDoublesParams.SuspendLayout();
			this.collapsableIntsParams.WorkingArea.SuspendLayout();
			this.collapsableIntsParams.SuspendLayout();
			this.collapsableIdsParams.WorkingArea.SuspendLayout();
			this.collapsableIdsParams.SuspendLayout();
			this.collapsableNoParams.WorkingArea.SuspendLayout();
			this.collapsableNoParams.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this.gensListControl1);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Panel1MinSize = 150;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.AutoScroll = true;
			this.splitContainer1.Panel2.Controls.Add(this.collapsableStringsParams);
			this.splitContainer1.Panel2.Controls.Add(this.collapsableDates);
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
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.labelName);
			this.panel2.Controls.Add(this.textBoxName);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(4, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(267, 43);
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
			// gensListControl1
			// 
			this.gensListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gensListControl1.Location = new System.Drawing.Point(4, 4);
			this.gensListControl1.Name = "gensListControl1";
			this.gensListControl1.Padding = new System.Windows.Forms.Padding(4);
			this.gensListControl1.Size = new System.Drawing.Size(142, 648);
			this.gensListControl1.TabIndex = 0;
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
			this.collapsableStringsParams.Location = new System.Drawing.Point(4, 384);
			this.collapsableStringsParams.Name = "collapsableStringsParams";
			this.collapsableStringsParams.Padding = new System.Windows.Forms.Padding(4);
			this.collapsableStringsParams.Size = new System.Drawing.Size(267, 313);
			this.collapsableStringsParams.TabIndex = 19;
			// 
			// collapsableStringsParams.WorkingArea
			// 
			this.collapsableStringsParams.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.collapsableStringsParams.WorkingArea.Controls.Add(this.stringsParamsControl);
			this.collapsableStringsParams.WorkingArea.Controls.Add(this.checkBoxLimitedStrings);
			this.collapsableStringsParams.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collapsableStringsParams.WorkingArea.Location = new System.Drawing.Point(4, 18);
			this.collapsableStringsParams.WorkingArea.Name = "WorkingArea";
			this.collapsableStringsParams.WorkingArea.Size = new System.Drawing.Size(259, 291);
			this.collapsableStringsParams.WorkingArea.TabIndex = 2;
			// 
			// stringsParamsControl
			// 
			this.stringsParamsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stringsParamsControl.Location = new System.Drawing.Point(0, 17);
			this.stringsParamsControl.Name = "stringsParamsControl";
			this.stringsParamsControl.Padding = new System.Windows.Forms.Padding(4);
			this.stringsParamsControl.Size = new System.Drawing.Size(259, 274);
			this.stringsParamsControl.TabIndex = 1;
			this.stringsParamsControl.UseLimitedStrings = false;
			// 
			// checkBoxLimitedStrings
			// 
			this.checkBoxLimitedStrings.AutoSize = true;
			this.checkBoxLimitedStrings.Dock = System.Windows.Forms.DockStyle.Top;
			this.checkBoxLimitedStrings.Location = new System.Drawing.Point(0, 0);
			this.checkBoxLimitedStrings.Name = "checkBoxLimitedStrings";
			this.checkBoxLimitedStrings.Size = new System.Drawing.Size(259, 17);
			this.checkBoxLimitedStrings.TabIndex = 2;
			this.checkBoxLimitedStrings.Text = "Limited Strings";
			this.checkBoxLimitedStrings.UseVisualStyleBackColor = true;
			// 
			// collapsableControl1
			// 
			this.collapsableDates.AllowDrop = true;
			this.collapsableDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.collapsableDates.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.collapsableDates.Caption = "Dates Parameters";
			this.collapsableDates.CaptionCollapsed = "";
			this.collapsableDates.CaptionOppositeAlignment = false;
			this.collapsableDates.Collapsable = true;
			this.collapsableDates.Collapsed = false;
			this.collapsableDates.ControlOrientation = System.Windows.Forms.Orientation.Horizontal;
			this.collapsableDates.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsableDates.Location = new System.Drawing.Point(4, 294);
			this.collapsableDates.Name = "collapsableControl1";
			this.collapsableDates.Padding = new System.Windows.Forms.Padding(4);
			this.collapsableDates.Size = new System.Drawing.Size(267, 90);
			this.collapsableDates.TabIndex = 23;
			// 
			// collapsableControl1.WorkingArea
			// 
			this.collapsableDates.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.collapsableDates.WorkingArea.Controls.Add(this.datesParamsControl);
			this.collapsableDates.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collapsableDates.WorkingArea.Location = new System.Drawing.Point(4, 18);
			this.collapsableDates.WorkingArea.Name = "WorkingArea";
			this.collapsableDates.WorkingArea.Size = new System.Drawing.Size(259, 68);
			this.collapsableDates.WorkingArea.TabIndex = 2;
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
			this.collapsableDoublesParams.Location = new System.Drawing.Point(4, 272);
			this.collapsableDoublesParams.Name = "collapsableDoublesParams";
			this.collapsableDoublesParams.Padding = new System.Windows.Forms.Padding(4);
			this.collapsableDoublesParams.Size = new System.Drawing.Size(267, 22);
			this.collapsableDoublesParams.TabIndex = 22;
			// 
			// collapsableDoublesParams.WorkingArea
			// 
			this.collapsableDoublesParams.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.collapsableDoublesParams.WorkingArea.Controls.Add(this.doublesParamsControl);
			this.collapsableDoublesParams.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collapsableDoublesParams.WorkingArea.Location = new System.Drawing.Point(4, 18);
			this.collapsableDoublesParams.WorkingArea.Name = "WorkingArea";
			this.collapsableDoublesParams.WorkingArea.Size = new System.Drawing.Size(259, 101);
			this.collapsableDoublesParams.WorkingArea.TabIndex = 2;
			// 
			// doublesParamsControl
			// 
			this.doublesParamsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.doublesParamsControl.Location = new System.Drawing.Point(0, 0);
			this.doublesParamsControl.Name = "doublesParamsControl";
			this.doublesParamsControl.Padding = new System.Windows.Forms.Padding(4);
			this.doublesParamsControl.Size = new System.Drawing.Size(259, 101);
			this.doublesParamsControl.TabIndex = 1;
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
			this.collapsableIntsParams.Collapsed = false;
			this.collapsableIntsParams.ControlOrientation = System.Windows.Forms.Orientation.Horizontal;
			this.collapsableIntsParams.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsableIntsParams.Location = new System.Drawing.Point(4, 181);
			this.collapsableIntsParams.Name = "collapsableIntsParams";
			this.collapsableIntsParams.Padding = new System.Windows.Forms.Padding(4);
			this.collapsableIntsParams.Size = new System.Drawing.Size(267, 91);
			this.collapsableIntsParams.TabIndex = 20;
			// 
			// collapsableIntsParams.WorkingArea
			// 
			this.collapsableIntsParams.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.collapsableIntsParams.WorkingArea.Controls.Add(this.intsParamsControl);
			this.collapsableIntsParams.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collapsableIntsParams.WorkingArea.Location = new System.Drawing.Point(4, 18);
			this.collapsableIntsParams.WorkingArea.Name = "WorkingArea";
			this.collapsableIntsParams.WorkingArea.Size = new System.Drawing.Size(259, 69);
			this.collapsableIntsParams.WorkingArea.TabIndex = 2;
			// 
			// intsParamsControl
			// 
			this.intsParamsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.intsParamsControl.Location = new System.Drawing.Point(0, 0);
			this.intsParamsControl.Name = "intsParamsControl";
			this.intsParamsControl.Padding = new System.Windows.Forms.Padding(4);
			this.intsParamsControl.Size = new System.Drawing.Size(259, 69);
			this.intsParamsControl.TabIndex = 14;
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
			this.collapsableIdsParams.Collapsed = false;
			this.collapsableIdsParams.ControlOrientation = System.Windows.Forms.Orientation.Horizontal;
			this.collapsableIdsParams.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsableIdsParams.Location = new System.Drawing.Point(4, 91);
			this.collapsableIdsParams.Name = "collapsableIdsParams";
			this.collapsableIdsParams.Padding = new System.Windows.Forms.Padding(4);
			this.collapsableIdsParams.Size = new System.Drawing.Size(267, 90);
			this.collapsableIdsParams.TabIndex = 17;
			// 
			// collapsableIdsParams.WorkingArea
			// 
			this.collapsableIdsParams.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.collapsableIdsParams.WorkingArea.Controls.Add(this.idsParamsControl);
			this.collapsableIdsParams.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collapsableIdsParams.WorkingArea.Location = new System.Drawing.Point(4, 18);
			this.collapsableIdsParams.WorkingArea.Name = "WorkingArea";
			this.collapsableIdsParams.WorkingArea.Size = new System.Drawing.Size(259, 68);
			this.collapsableIdsParams.WorkingArea.TabIndex = 2;
			// 
			// idsParamsControl
			// 
			this.idsParamsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.idsParamsControl.Location = new System.Drawing.Point(0, 0);
			this.idsParamsControl.Name = "idsParamsControl";
			this.idsParamsControl.Padding = new System.Windows.Forms.Padding(4);
			this.idsParamsControl.Size = new System.Drawing.Size(259, 68);
			this.idsParamsControl.TabIndex = 1;
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
			this.collapsableNoParams.Size = new System.Drawing.Size(267, 44);
			this.collapsableNoParams.TabIndex = 21;
			// 
			// collapsableNoParams.WorkingArea
			// 
			this.collapsableNoParams.WorkingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.collapsableNoParams.WorkingArea.Controls.Add(this.noParamsControl);
			this.collapsableNoParams.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
			this.collapsableNoParams.WorkingArea.Location = new System.Drawing.Point(4, 18);
			this.collapsableNoParams.WorkingArea.Name = "WorkingArea";
			this.collapsableNoParams.WorkingArea.Size = new System.Drawing.Size(259, 22);
			this.collapsableNoParams.WorkingArea.TabIndex = 2;
			// 
			// noParamsControl
			// 
			this.noParamsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.noParamsControl.Location = new System.Drawing.Point(0, 0);
			this.noParamsControl.Name = "noParamsControl";
			this.noParamsControl.Padding = new System.Windows.Forms.Padding(4);
			this.noParamsControl.Size = new System.Drawing.Size(259, 22);
			this.noParamsControl.TabIndex = 16;
			// 
			// datesParamsControl1
			// 
			this.datesParamsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.datesParamsControl.Location = new System.Drawing.Point(0, 0);
			this.datesParamsControl.Name = "datesParamsControl1";
			this.datesParamsControl.Padding = new System.Windows.Forms.Padding(4);
			this.datesParamsControl.Size = new System.Drawing.Size(259, 68);
			this.datesParamsControl.TabIndex = 0;
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
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.collapsableStringsParams.WorkingArea.ResumeLayout(false);
			this.collapsableStringsParams.WorkingArea.PerformLayout();
			this.collapsableStringsParams.ResumeLayout(false);
			this.collapsableDates.WorkingArea.ResumeLayout(false);
			this.collapsableDates.ResumeLayout(false);
			this.collapsableDoublesParams.WorkingArea.ResumeLayout(false);
			this.collapsableDoublesParams.ResumeLayout(false);
			this.collapsableIntsParams.WorkingArea.ResumeLayout(false);
			this.collapsableIntsParams.ResumeLayout(false);
			this.collapsableIdsParams.WorkingArea.ResumeLayout(false);
			this.collapsableIdsParams.ResumeLayout(false);
			this.collapsableNoParams.WorkingArea.ResumeLayout(false);
			this.collapsableNoParams.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private EugeneAnykey.Forms.Controls.CollapsableControl collapsableNoParams;
		private EugeneAnykey.Forms.Controls.CollapsableControl collapsableIdsParams;
		private EugeneAnykey.Forms.Controls.CollapsableControl collapsableIntsParams;
		private EugeneAnykey.Forms.Controls.CollapsableControl collapsableDoublesParams;
		private EugeneAnykey.Forms.Controls.CollapsableControl collapsableStringsParams;
		private GenControls.NoParamsControl noParamsControl;
		private GenControls.IdsParamsControl idsParamsControl;
		private GenControls.IntsParamsControl intsParamsControl;
		private GenControls.DoublesParamsControl doublesParamsControl;
		private GenControls.LimitedStringsParamsControl stringsParamsControl;
		private System.Windows.Forms.CheckBox checkBoxLimitedStrings;
		private GensListControl gensListControl1;
		private EugeneAnykey.Forms.Controls.CollapsableControl collapsableDates;
		private GenControls.DatesParamsControl datesParamsControl;
	}
}
