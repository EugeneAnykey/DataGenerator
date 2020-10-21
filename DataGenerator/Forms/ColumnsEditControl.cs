using System.Windows.Forms;
using EugeneAnykey.Forms.Controls;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class ColumnsEditControl : UserControl
	{
		#region field
		UserControl[] ugens;
		CollapsableControl[] collapsables;
		string[] names;
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
			collapsables = new[] {
				collapsableNothing,
				collapsableConstant,
				collapsableIds,
				collapsableInts,
				collapsableDoubles,
				collapsableDates,
				collapsableMaskedIds,
				collapsableStrings,
				collapsableRndSymbols,
			};

			names = new[] {
				"Nothing",
				"Constant",
				"Id",
				"Int",
				"Double",
				"Date",
				"Masked Id",
				"String",
				"RndSymbols",
			};

			ugens = new UserControl[] {
				noParamsControl,
				constantsParamsControl,
				idsParamsControl,
				intsParamsControl,
				doublesParamsControl,
				datesParamsControl,
				maskedIdsParamsControl,
				stringsParamsControl,
				rndSymbolsParamsControl,
			};

			Recolor();

			ShowOnly(collapsableNothing);
		}

		void Recolor()
		{
			var colorer = new EugeneAnykey.Forms.Colorer();

			foreach (var item in collapsables)
			{
				item.BaseColor = item.BackColor = colorer.GetNext();
			}
		}

		void InitEvent()
		{
			gensListControl1.AddingItem += (_, gen) => AddingItem(gen);
			gensListControl1.AddingRandomItem += (_, gen) => AddingRandomItem(gen);
			gensListControl1.AddingMiscRandomItem += (_, gen) => AddingMiscRandomItem(gen);
			gensListControl1.ItemSelected += (_, gen) => SelectingItem(gen);

			foreach (var col in collapsables)
			{
				col.CollapseStateChanged += (_, __) => ShowOnly(col);
			}
		}
		#endregion


		#region public: GetBaseGens, SetBaseGens
		public BaseGen[] GetBaseGens() => gensListControl1.GetBaseGens();
		public void SetBaseGens(BaseGen[] gens) => gensListControl1.SetBaseGens(gens);
		#endregion


		#region private Random: GetCurrentGenGetter, AddingRandomItem, AddingMiscRandomItem
		IGenGetter GetCurrentGenGetter()
		{
			for (int i = 0; i < collapsables.Length; i++)
				if (!collapsables[i].Collapsed)
					return ugens[i] as IGenGetter;
			return null;
		}

		void AddingRandomItem(GenItemEventArgs genItemArgs)
		{
			if (GetCurrentGenGetter() is IGenRandomGetter rgen)
				genItemArgs.Gen = rgen.GetRandomBaseGen();
		}

		void AddingMiscRandomItem(GenItemEventArgs genItemArgs)
		{
			var index = Randomizer.R.Next(ugens.Length);
			var gen = ugens[index] as IGenGetter;
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
			for (int i = 0; i < collapsables.Length; i++)
				if (collapsables[i] == collapsable)
					return i;

			return -1;
		}

		void SelectingItem(GenItemEventArgs genItemArgs)
		{
			ShowOnly(genItemArgs.Gen);
		}

		void ShowOnly(BaseGen gen)
		{
			int index =
				gen is NothingGen ? 0 :
				gen is ConstantStringsGen ? 1 :
				gen is IdsGen ? 2 :
				gen is IntegersGen ? 3 :
				gen is DoublesGen ? 4 :
				gen is DatesGen ? 5 :
				gen is MaskedIdsGen ? 6 :
				gen is StringsGen ? 7 :
				gen is RndSymbolsGen ? 8 :
				-1;

			ActivateGen(collapsables[index], ugens[index] as IGenSetter, gen);
		}

		void ShowOnly(CollapsableControl collapsable)
		{
			foreach (var c in collapsables)
			{
				if (!c.Collapsed && c != collapsable)
					c.Collapsed = true;
			}

			textBoxName.Text = names[GetPos(collapsable)];

			if (null == collapsable)
				return;

			if (collapsable.Collapsed)
				collapsable.Collapsed = false;
		}
		#endregion
	}
}
