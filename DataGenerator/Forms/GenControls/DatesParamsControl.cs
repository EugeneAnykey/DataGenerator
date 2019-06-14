using System;
using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.Forms.GenControls
{
	public partial class DatesParamsControl : UserControl, IGenGetter, IGenSetter, IGenRandomGetter
	{
		// IGenGetter
		public BaseGen GetBaseGen() => new DatesGen(dateTimePickerMin.Value, dateTimePickerMax.Value);

		// IGenRandomGetter
		public BaseGen GetRandomBaseGen()
		{
			TimeSpan ts() => new TimeSpan((20 + Randomizer.R.Next(30)) * 100, 0, 0, 0);
			string[] rndNames = new[] { "Date", "Start Date", "End Date", "Final", "Begining" };

			var min = DateTime.UtcNow.Subtract(ts());
			return new DatesGen(min, min.Add(ts())) { Name = Randomizer.OneOf(rndNames) };
		}

		// IGenSetter
		public void SetBaseGen(BaseGen gen)
		{
			if (gen is DatesGen gen1)
			{
				dateTimePickerMin.Value = gen1.Min;
				dateTimePickerMin.Value = gen1.Max;
			}
		}



		public DatesParamsControl()
		{
			InitializeComponent();

			dateTimePickerMin.Value = DateTime.UtcNow.Subtract(new TimeSpan(3600, 0, 0, 0));
			dateTimePickerMax.Value = DateTime.UtcNow;
		}
	}
}
