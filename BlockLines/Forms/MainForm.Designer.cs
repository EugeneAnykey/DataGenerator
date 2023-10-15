namespace EugeneAnykey.Project.BlockLines.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxLineBlock = new GroupBox();
            lineBlock1 = new BlockLineControl();
            pictureBox1 = new PictureBox();
            panelBottom = new Panel();
            button1 = new Button();
            listBox1 = new ListBox();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuFileSave = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            menuExit = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            panelButtons = new Panel();
            buttonRemove = new Button();
            buttonShow = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            groupBoxGraph = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            groupBoxLineBlock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBottom.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelButtons.SuspendLayout();
            groupBoxGraph.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxLineBlock
            // 
            groupBoxLineBlock.Controls.Add(lineBlock1);
            groupBoxLineBlock.Dock = DockStyle.Left;
            groupBoxLineBlock.Location = new Point(4, 4);
            groupBoxLineBlock.Name = "groupBoxLineBlock";
            groupBoxLineBlock.Size = new Size(266, 380);
            groupBoxLineBlock.TabIndex = 1;
            groupBoxLineBlock.TabStop = false;
            groupBoxLineBlock.Text = "Line Block";
            // 
            // lineBlock1
            // 
            lineBlock1.Dock = DockStyle.Fill;
            lineBlock1.Location = new Point(3, 19);
            lineBlock1.Name = "lineBlock1";
            lineBlock1.Padding = new Padding(4);
            lineBlock1.Size = new Size(260, 358);
            lineBlock1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(4, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 356);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(button1);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 412);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(886, 55);
            panelBottom.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(12, 20);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(4, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(271, 380);
            listBox1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(886, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuFileSave, toolStripMenuItem1, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(38, 20);
            menuFile.Text = "File";
            // 
            // menuFileSave
            // 
            menuFileSave.Name = "menuFileSave";
            menuFileSave.Size = new Size(112, 22);
            menuFileSave.Text = "Save…";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(109, 6);
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(112, 22);
            menuExit.Text = "Exit";
            // 
            // menuAbout
            // 
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new Size(53, 20);
            menuAbout.Text = "About";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBox1);
            splitContainer1.Panel1.Controls.Add(panelButtons);
            splitContainer1.Panel1.Padding = new Padding(4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxGraph);
            splitContainer1.Panel2.Controls.Add(groupBoxLineBlock);
            splitContainer1.Panel2.Padding = new Padding(4);
            splitContainer1.Size = new Size(886, 388);
            splitContainer1.SplitterDistance = 319;
            splitContainer1.TabIndex = 7;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonRemove);
            panelButtons.Controls.Add(buttonShow);
            panelButtons.Controls.Add(buttonUpdate);
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Dock = DockStyle.Right;
            panelButtons.Location = new Point(275, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(40, 380);
            panelButtons.TabIndex = 6;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(6, 142);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(31, 23);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "X";
            buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(6, 102);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(31, 23);
            buttonShow.TabIndex = 2;
            buttonShow.Text = ">";
            buttonShow.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(6, 61);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(31, 23);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "<>";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(6, 20);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(31, 23);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "<";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // groupBoxGraph
            // 
            groupBoxGraph.Controls.Add(pictureBox1);
            groupBoxGraph.Dock = DockStyle.Fill;
            groupBoxGraph.Location = new Point(270, 4);
            groupBoxGraph.Name = "groupBoxGraph";
            groupBoxGraph.Padding = new Padding(4);
            groupBoxGraph.Size = new Size(289, 380);
            groupBoxGraph.TabIndex = 2;
            groupBoxGraph.TabStop = false;
            groupBoxGraph.Text = "Graph";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 467);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(886, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(127, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 489);
            Controls.Add(splitContainer1);
            Controls.Add(panelBottom);
            Controls.Add(menuStrip1);
            Controls.Add(statusStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            groupBoxLineBlock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBottom.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            groupBoxGraph.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBoxLineBlock;
        private PictureBox pictureBox1;
        private BlockLineControl lineBlock1;
        private Panel panelBottom;
        private Button button1;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuExit;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem menuFileSave;
        private ToolStripMenuItem menuAbout;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxGraph;
        private Panel panelButtons;
        private Button buttonShow;
        private Button buttonUpdate;
        private Button buttonAdd;
        private Button buttonRemove;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}