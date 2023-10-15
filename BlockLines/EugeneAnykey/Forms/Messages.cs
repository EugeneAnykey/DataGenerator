namespace EugeneAnykey.Forms
{
    public static class Messages
    {
        // Asks
        public static bool AskToClear()
        {
            return DialogResult.Yes == MessageBox.Show("Clear all?", "Clear?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
        }

        public static bool AskToSaveData(bool gotChanges)
        {
            return gotChanges && DialogResult.Yes == MessageBox.Show("Data changed. Do you want to save changes?", "Do save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
