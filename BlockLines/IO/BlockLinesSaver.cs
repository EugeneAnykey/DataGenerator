namespace EugeneAnykey.Project.BlockLines.Types
{
    public static class BlockLinesSaver
    {
        public static void Write(string filename, ListBox listBox)
        {
            var lines = new List<string>
            {
                "Name\tline 1\tline 2\tline 3\tline 4\tline 5"
            };

            foreach (var item in listBox.Items)
            {
                if (item is not BlockLineItem lineBlockItem) continue;

                string joined = string.Join("\t", lineBlockItem.Values);

                lines.Add($"{lineBlockItem.Name}\t{joined}");
            }

            File.WriteAllLines(filename, lines);
        }
    }
}
