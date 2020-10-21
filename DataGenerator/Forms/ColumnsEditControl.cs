using System.Windows.Forms;
using EugeneAnykey.Forms.Controls;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class ColumnsEditControl : UserControl
	{
		#region struct GeneratorUnit
		struct GeneratorUnit {
			public UserControl GenControl { get; }
			public CollapsableControl Collapsable { get; }
			public string DisplayName { get; }

			public GeneratorUnit(UserControl genControl, CollapsableControl collapsableControl, string displayName)
			{
				GenControl = genControl;
				Collapsable = collapsableControl;
				DisplayName = displayName;
			}
		}
		#endregion


		#region field
		GeneratorUnit[] genUnits;
		#endregion


		#region init
		public ColumnsEditControl()
		{
			InitializeComponent();

			Init();
			InitEvent();
		}

		void Init()
		{
			genUnits = new[] {
				new GeneratorUnit(noParamsControl, collapsableNothing, "Nothing"),
				new GeneratorUnit(constantsParamsControl, collapsableConstant, "Constant"),
				new GeneratorUnit(idsParamsControl, collapsableIds, "Id"),
				new GeneratorUnit(intsParamsControl, collapsableInts, "Int"),
				new GeneratorUnit(doublesParamsControl, collapsableDoubles, "Double"),
				new GeneratorUnit(datesParamsControl, collapsableDates, "Date"),
				new GeneratorUnit(maskedIdsParamsControl, collapsableMaskedIds, "Masked_Id"),
				new GeneratorUnit(stringsParamsControl, collapsableStrings, "String"),
				new GeneratorUnit(rndSymbolsParamsControl, collapsableRndSymbols, "RndSymbols"),
			};

			Recolor();

			ShowOnly(collapsableNothing);
		}

		void Recolor()
		{
			var colorer = new EugeneAnykey.Forms.Colorer();

			foreach (var item in genUnits)
			{
				item.Collapsable.BaseColor = item.Collapsable.BackColor = colorer.GetNext();
			}
		}

		void InitEvent()
		{
			gensListControl1.AddingItem += (_, gen) => AddingItem(gen);
			gensListControl1.AddingRandomItem += (_, gen) => AddingRandomItem(gen);
			gensListControl1.AddingMiscRandomItem += (_, gen) => AddingMiscRandomItem(gen);
			gensListControl1.ItemSelected += (_, gen) => SelectingItem(gen);

			foreach (var item in genUnits)
			{
				item.Collapsable.CollapseStateChanged += (_, __) => ShowOnly(item.Collapsable);
			}
		}
		#endregion


		#region public: GetBaseGens, SetBaseGens
		public BaseGen[] GetBaseGens() => gensListControl1.GetBaseGens();
		public void SetBaseGens(BaseGen[] gens) => gensListControl1.SetBaseGens(gens);
		#endregion


		#region private: GetCurrentGenGetter
		IGenGetter GetCurrentGenGetter()
		{
			foreach (var item in genUnits)
			{
				if (!item.Collapsable.Collapsed)
					return item.GenControl as IGenGetter;
			}
			return null;
		}
		#endregion


		#region private Random: GetCurrentGenGetter, AddingRandomItem, AddingMiscRandomItem
		void AddingRandomItem(GenItemEventArgs genItemArgs)
		{
			if (GetCurrentGenGetter() is IGenRandomGetter rgen)
				genItemArgs.Gen = rgen.GetRandomBaseGen();
		}

		void AddingMiscRandomItem(GenItemEventArgs genItemArgs)
		{
			var index = Randomizer.R.Next(genUnits.Length);
			var gen = genUnits[index].GenControl as IGenGetter;
			if (gen is IGenRandomGetter rgen)
				genItemArgs.Gen = rgen.GetRandomBaseGen();
		}
		#endregion


		#region private: ActivateGen, AddingItem
		void ActivateGen(CollapsableControl control, IGenSetter igen, BaseGen gen)
		{
			ShowOnly(control);
			igen.SetBaseGen(gen);
			textBoxName.Text = gen.Name;
		}

		void AddingItem(GenItemEventArgs genItemArgs)
		{
			genItemArgs.Gen = GetCurrentGenGetter()?.GetBaseGen();
			if (genItemArgs.Gen != null)
				genItemArgs.Gen.Name = textBoxName.Text;
		}
		#endregion


		#region private: GetPos, SelectingItem, ShowOnly
		int GetPos(CollapsableControl collapsable)
		{
			for (int i = 0; i < genUnits.Length; i++) {
				if (genUnits[i].Collapsable == collapsable)
					return i;
			}
			return -1;
		}

		int GetPos(BaseGen gen)
		{
			return gen is NothingGen ? 0 :
				gen is ConstantStringsGen ? 1 :
				gen is IdsGen ? 2 :
				gen is IntegersGen ? 3 :
				gen is DoublesGen ? 4 :
				gen is DatesGen ? 5 :
				gen is MaskedIdsGen ? 6 :
				gen is StringsGen ? 7 :
				gen is RndSymbolsGen ? 8 :
				-1;
		}

		void SelectingItem(GenItemEventArgs genItemArgs)
		{
			ShowOnly(genItemArgs.Gen);
		}

		void ShowOnly(BaseGen gen)
		{
			int index = GetPos(gen);
			ActivateGen(genUnits[index].Collapsable, genUnits[index].GenControl as IGenSetter, gen);
		}

		void ShowOnly(CollapsableControl collapsable)
		{
			foreach (var item in genUnits)
			{
				var c = item.Collapsable;
				if (!c.Collapsed && c != collapsable)
					c.Collapsed = true;
			}
			
			textBoxName.Text = genUnits[GetPos(collapsable)].DisplayName;

			if (null == collapsable)
				return;

			if (collapsable.Collapsed)
				collapsable.Collapsed = false;
		}
		#endregion
	}
}
