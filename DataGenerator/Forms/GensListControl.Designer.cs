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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GensListControl));
			this.groupBoxMain = new System.Windows.Forms.GroupBox();
			this.listBox = new System.Windows.Forms.ListBox();
			this.panelSide = new System.Windows.Forms.Panel();
			this.buttonAddRandom = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonReplace = new System.Windows.Forms.Button();
			this.buttonAddMiscRandom = new System.Windows.Forms.Button();
			this.buttonNothing = new System.Windows.Forms.Button();
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
			// listBox
			// 
			this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox.FormattingEnabled = true;
			this.listBox.Location = new System.Drawing.Point(3, 16);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(226, 401);
			this.listBox.TabIndex = 3;
			// 
			// panelSide
			// 
			this.panelSide.Controls.Add(this.buttonNothing);
			this.panelSide.Controls.Add(this.buttonAddMiscRandom);
			this.panelSide.Controls.Add(this.buttonReplace);
			this.panelSide.Controls.Add(this.buttonAddRandom);
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
			// buttonAddCurrentRandom
			// 
			this.buttonAddRandom.FlatAppearance.BorderSize = 0;
			this.buttonAddRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddRandom.ImageIndex = 4;
			this.buttonAddRandom.ImageList = this.imageList1;
			this.buttonAddRandom.Location = new System.Drawing.Point(6, 12);
			this.buttonAddRandom.Name = "buttonAddCurrentRandom";
			this.buttonAddRandom.Size = new System.Drawing.Size(32, 32);
			this.buttonAddRandom.TabIndex = 6;
			this.buttonAddRandom.UseVisualStyleBackColor = true;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "add.png");
			this.imageList1.Images.SetKeyName(1, "remove.png");
			this.imageList1.Images.SetKeyName(2, "direction_up.png");
			this.imageList1.Images.SetKeyName(3, "direction_down.png");
			this.imageList1.Images.SetKeyName(4, "question.png");
			this.imageList1.Images.SetKeyName(5, "questions.png");
			this.imageList1.Images.SetKeyName(6, "action_round.png");
			// 
			// buttonAdd
			// 
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.ImageIndex = 0;
			this.buttonAdd.ImageList = this.imageList1;
			this.buttonAdd.Location = new System.Drawing.Point(6, 88);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(32, 32);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// buttonDown
			// 
			this.buttonDown.FlatAppearance.BorderSize = 0;
			this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDown.ImageIndex = 3;
			this.buttonDown.ImageList = this.imageList1;
			this.buttonDown.Location = new System.Drawing.Point(6, 164);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(32, 32);
			this.buttonDown.TabIndex = 4;
			this.buttonDown.UseVisualStyleBackColor = true;
			// 
			// buttonUp
			// 
			this.buttonUp.FlatAppearance.BorderSize = 0;
			this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonUp.ImageIndex = 2;
			this.buttonUp.ImageList = this.imageList1;
			this.buttonUp.Location = new System.Drawing.Point(6, 126);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(32, 32);
			this.buttonUp.TabIndex = 3;
			this.buttonUp.UseVisualStyleBackColor = true;
			// 
			// buttonRemove
			// 
			this.buttonRemove.FlatAppearance.BorderSize = 0;
			this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonRemove.ImageIndex = 1;
			this.buttonRemove.ImageList = this.imageList1;
			this.buttonRemove.Location = new System.Drawing.Point(6, 278);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(32, 32);
			this.buttonRemove.TabIndex = 2;
			this.buttonRemove.UseVisualStyleBackColor = true;
			// 
			// buttonModify
			// 
			this.buttonReplace.FlatAppearance.BorderSize = 0;
			this.buttonReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonReplace.ImageIndex = 6;
			this.buttonReplace.ImageList = this.imageList1;
			this.buttonReplace.Location = new System.Drawing.Point(6, 202);
			this.buttonReplace.Name = "buttonModify";
			this.buttonReplace.Size = new System.Drawing.Size(32, 32);
			this.buttonReplace.TabIndex = 7;
			this.buttonReplace.UseVisualStyleBackColor = true;
			// 
			// buttonAddMiscRandom
			// 
			this.buttonAddMiscRandom.FlatAppearance.BorderSize = 0;
			this.buttonAddMiscRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddMiscRandom.ImageIndex = 5;
			this.buttonAddMiscRandom.ImageList = this.imageList1;
			this.buttonAddMiscRandom.Location = new System.Drawing.Point(6, 50);
			this.buttonAddMiscRandom.Name = "buttonAddMiscRandom";
			this.buttonAddMiscRandom.Size = new System.Drawing.Size(32, 32);
			this.buttonAddMiscRandom.TabIndex = 8;
			this.buttonAddMiscRandom.UseVisualStyleBackColor = true;
			// 
			// buttonNothing
			// 
			this.buttonNothing.FlatAppearance.BorderSize = 0;
			this.buttonNothing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNothing.ImageList = this.imageList1;
			this.buttonNothing.Location = new System.Drawing.Point(6, 240);
			this.buttonNothing.Name = "buttonNothing";
			this.buttonNothing.Size = new System.Drawing.Size(32, 32);
			this.buttonNothing.TabIndex = 9;
			this.buttonNothing.UseVisualStyleBackColor = true;
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
		private System.Windows.Forms.Button buttonAddRandom;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button buttonReplace;
		private System.Windows.Forms.Button buttonAddMiscRandom;
		private System.Windows.Forms.Button buttonNothing;
	}
}
