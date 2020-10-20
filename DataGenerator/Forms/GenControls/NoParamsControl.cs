using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	public partial class NoParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// IGenGetter
		public BaseGen GetBaseGen() => new NothingGen();

		// IGenRandomGetter
		public BaseGen GetRandomBaseGen()
		{
			string[] rndNames = new[] { "Nothing", "Empty", "Void" };
			return new NothingGen() { Name = Randomizer.OneOf(rndNames) };
		}

		// IGenSetter
		public void SetBaseGen(BaseGen gen) { }



		public NoParamsControl()
		{
			InitializeComponent();
			new Exampler(labelExample, GetBaseGen);
		}
	}
}
