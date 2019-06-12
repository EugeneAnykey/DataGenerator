namespace EugeneAnykey.Project.DataGenerator.Forms
{
	partial class GensListControl
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
			this.groupBoxMain = new System.Windows.Forms.GroupBox();
			this.listBox = new System.Windows.Forms.ListBox();
			this.panelSide = new System.Windows.Forms.Panel();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.groupBoxMain.SuspendLayout();
			this.panelSide.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxMain
			// 
			this.groupBoxMain.Controls.Add(this.listBox);
			this.groupBoxMain.Controls.Add(this.panelSide);
			this.groupBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxMain.Location = new System.Drawing.Point(4, 4);
			this.groupBoxMain.Name = "groupBoxMain";
			this.groupBoxMain.Size = new System.Drawing.Size(274, 420);
			this.groupBoxMain.TabIndex = 0;
			this.groupBoxMain.TabStop = false;
			this.groupBoxMain.Text = "groupBox1";
			// 
			// listBox1
			// 
			this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(3, 16);
			this.listBox.Name = "listBox1";
			this.listBox.Size = new System.Drawing.Size(226, 401);
			this.listBox.TabIndex = 3;
			// 
			// panelSide
			// 
			this.panelSide.Controls.Add(this.buttonAdd);
			this.panelSide.Controls.Add(this.buttonDown);
			this.panelSide.Controls.Add(this.buttonUp);
			this.panelSide.Controls.Add(this.buttonRemove);
			this.panelSide.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelSide.Location = new System.Drawing.Point(229, 16);
			this.panelSide.Name = "panelSide";
			this.panelSide.Size = new System.Drawing.Size(42, 401);
			this.panelSide.TabIndex = 5;
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(6, 55);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(29, 23);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "<";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// buttonDown
			// 
			this.buttonDown.Location = new System.Drawing.Point(6, 152);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(29, 23);
			this.buttonDown.TabIndex = 4;
			this.buttonDown.Text = "v";
			this.buttonDown.UseVisualStyleBackColor = true;
			// 
			// buttonUp
			// 
			this.buttonUp.Location = new System.Drawing.Point(6, 123);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(29, 23);
			this.buttonUp.TabIndex = 3;
			this.buttonUp.Text = "^";
			this.buttonUp.UseVisualStyleBackColor = true;
			// 
			// buttonRemove
			// 
			this.buttonRemove.Location = new System.Drawing.Point(6, 213);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(29, 23);
			this.buttonRemove.TabIndex = 2;
			this.buttonRemove.Text = ">";
			this.buttonRemove.UseVisualStyleBackColor = true;
			// 
			// GensListControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxMain);
			this.Name = "GensListControl";
			this.Padding = new System.Windows.Forms.Padding(4);
			this.Size = new System.Drawing.Size(282, 428);
			this.groupBoxMain.ResumeLayout(false);
			this.panelSide.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxMain;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Panel panelSide;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonRemove;
	}
}
