using System;

namespace EugeneAnykey.Project.DataGenerator
{
	// EventHandler
	public delegate void GenItemEventHandler(object sender, GenItemEventArgs args);



	// EventArgs
	public class GenItemEventArgs : EventArgs
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

		public GenItemEventArgs(BaseGen gen)
		{
			Gen = gen;
		}
	}
}
