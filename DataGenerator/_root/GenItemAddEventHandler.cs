using System;

namespace EugeneAnykey.Project.DataGenerator
{
	// EventHandler
	public delegate void GenItemAddEventHandler(object sender, GenItemAddEventArgs args);



	// EventArgs
	public class GenItemAddEventArgs : EventArgs
	{
		BaseGen gen;
		public BaseGen Gen
		{
			get => gen;
			set
			{
				gen = value;
				Cancel = gen == null;
			}
		}

		public bool Cancel { get; private set; }

		public GenItemAddEventArgs(BaseGen gen)
		{
			Gen = gen;
		}
	}
}
