namespace EugeneAnykey.Project.BlockLines.Types
{
    public class BlockLineItem
    {
        const int MaxLinesCount = 5;

        public string Name { get; private set; }
        public int[] Values { get; private set; } = new int[MaxLinesCount] { 0, 0, 0, 0, 0 };

        public BlockLineItem(string name, int[] values)
        {
            Name = name;

            Fill(values);
        }

        public void Erase()
        {
            for (int i = 0; i < MaxLinesCount; i++)
            {
                Values[i] = 0;
            }
        }

        public void Fill(int[] values)
        {
            for (int i = 0; i < values.Length && i < MaxLinesCount; i++)
            {
                Values[i] = values[i];
            }
        }

        public void Rename(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            string joined = string.Join(", ", Values);

            return $"{Name} → [{joined}]";
        }
    }
}
