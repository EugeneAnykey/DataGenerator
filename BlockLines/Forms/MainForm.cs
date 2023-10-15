using EugeneAnykey.Forms;

using EugeneAnykey.Project.BlockLines.Types;

namespace EugeneAnykey.Project.BlockLines.Forms
{
    public partial class MainForm : Form
    {
        #region fields
        readonly ChangesCounter change = new();
        #endregion


        #region init
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            Text = Application.ProductName;

            buttonRemove.Click += Remove;
            buttonAdd.Click += AddItem;
            buttonUpdate.Click += UpdateItem;
            buttonShow.Click += ShowItem;

            menuAbout.Click += About.Show;
            menuExit.Click += Exit;
            menuFileSave.Click += SaveFile;
        }

        private void Exit(object? sender, EventArgs e)
        {
            if (Messages.AskToSaveData(change.GotChanges))
            {
                SaveFile(this, e);
            }
            Application.Exit();
        }

        private void SaveFile(object? sender, EventArgs e)
        {
            if (change.GotChanges)
            {
                MessageBox.Show(change.Info, "Info before save");
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BlockLinesSaver.Write(saveFileDialog1.FileName, listBox1);
                change.Reset();
            }
        }
        #endregion



        #region Button
        private void AddItem(object? sender, EventArgs e)
        {
            listBox1.Items.Add(lineBlock1.GetItem());
            change.IncAdditions();
        }

        private void Remove(object? sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            change.IncRemoves();
        }

        private void UpdateItem(object? sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index, lineBlock1.GetItem());
            change.IncUpdates();
        }

        private void ShowItem(object? sender, EventArgs e)
        {
            lineBlock1.SetItem(listBox1.SelectedItem as BlockLineItem);
        }
        #endregion
    }
}
