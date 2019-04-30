namespace EugeneAnykey.Project.DataGenerator
{
	class SeparatorItem
	{
		// field
		public char[] Separators { get; }
		public string Name { get; }



		// init
		public SeparatorItem(string name, params char[] separators)
		{
			Name = name;
			Separators = separators;
		}



		// override
		public override string ToString()
		{
			return Name;
		}
	}
}
