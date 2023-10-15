namespace EugeneAnykey.Project.BlockLines.Types
{
    public static class BlockLinesLoader
    {
        public static void Read(string filename, ListBox listBox)
        {
            string[] lines = File.ReadAllLines(filename);
            var blocks = new List<BlockLineItem>();

            foreach (var line in lines)
            {
                // string + [int x5] → s i i i i i
                string[] items = line.Split('\t');
                if (items.Length == 0 || items[0].Length == 0) { continue; }

                int[] values = items.Skip(1).Select(i => { _ = int.TryParse(i, out int v); return v; }).ToArray();
                blocks.Add(new BlockLineItem(items[0], values));
            }
            // Remove from HERE! to the `OpenFile`
            listBox.Items.Clear();

            listBox.Items.AddRange(blocks.ToArray());
        }
    }
}
