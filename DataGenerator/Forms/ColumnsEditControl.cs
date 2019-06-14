using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Forms.Controls;
using System;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class ColumnsEditControl : UserControl
	{
		// const



		// field
		//BaseGen gen;

		UserControl[] ugens;
		CollapsableControl[] collapsables;
		string[] names;



		// init
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
				collapsableIds,
				collapsableInts,
				collapsableDoubles,
				collapsableDates,
				collapsableMaskedIds,
				collapsableStrings,
			};

			names = new[] {
				"",
				"Nothing",
				"Id",
				"Int",
				"Double",
				"Date",
				"Masked Id",
				"String",
			};

			ugens = new UserControl[] {
				noParamsControl,
				idsParamsControl,
				intsParamsControl,
				doublesParamsControl,
				datesParamsControl,
				maskedIdsParamsControl,
				stringsParamsControl,
			};

			ShowOnly(collapsableNothing);
		}

		void InitEvent()
		{
			gensListControl1.AddingItem += (_, gen) => AddingItem(gen);
			gensListControl1.AddingRandomItem += (_, gen) => AddingRandomItem(gen);
			gensListControl1.ItemSelected += (_, gen) => SelectingItem(gen);

			foreach (var col in collapsables)
			{
				col.CollapseStateChanged += (_, __) => ShowOnly(col);
			}

			checkBoxLimitedStrings.CheckedChanged += (_, __) => ToggleLimitedStrings(checkBoxLimitedStrings.Checked);
		}

		void ToggleLimitedStrings(bool enable)
		{
			collapsableStrings.Caption = enable ? "Limited Strings Parameters" : "Strings Parameters";
			stringsParamsControl.UseLimitedStrings = enable;
		}



		// public
		public BaseGen[] GetBaseGens() => gensListControl1.GetBaseGens();



		// private
		void AddingRandomItem(GenItemEventArgs genItemArgs)
		{
			BaseGen gen = null;
			var index = Randomizer.R.Next(ugens.Length);

			if (ugens[index] is IGenRandomGetter ugen)
			{
				gen = ugen.GetRandomBaseGen();
				if (gen == null)
					return;

				genItemArgs.Gen = gen;
			}
		}



		void AddingItem(GenItemEventArgs genItemArgs)
		{
			IGenGetter ugen = null;
			for (int i = 0; i < collapsables.Length; i++)
			{
				if (!collapsables[i].Collapsed)
				{
					ugen = ugens[i] as IGenGetter;
					break;
				}
			}

			var gen = ugen?.GetBaseGen();

			if (gen == null)
				return;

			gen.Name = textBoxName.Text;

			genItemArgs.Gen = gen;
		}



		void SelectingItem(GenItemEventArgs genItemArgs)
		{
			ShowOnly(genItemArgs.Gen);
		}



		void ShowOnly(BaseGen gen)
		{
			int index =
				gen is NothingGen ? 0 :
				gen is IdsGen ? 1 :
				gen is IntegersGen ? 2 :
				gen is DoublesGen ? 3 :
				gen is DatesGen ? 4 :
				gen is MaskedIdsGen ? 5 :
				gen is StringsGen ? 6 :
				gen is LimitedStringsGen ? 7 :
				-1;

			ActivateGen(collapsables[index], ugens[index] as IGenSetter, gen);

			if (index == 6 || index == 7)
				stringsParamsControl.UseLimitedStrings = index == 7;
		}



		void ActivateGen(CollapsableControl control, IGenSetter igen, BaseGen gen)
		{
			ShowOnly(control);
			igen.SetBaseGen(gen);
			textBoxName.Text = gen.Name;
		}



		void ShowOnly(CollapsableControl collapsable)
		{
			foreach (var c in collapsables)
			{
				if (!c.Collapsed && c != collapsable)
					c.Collapsed = true;
			}

			textBoxName.Text = names[GetPos(collapsable) + 1];

			if (null == collapsable)
				return;

			if (collapsable.Collapsed)
				collapsable.Collapsed = false;
		}



		int GetPos(CollapsableControl collapsable)
		{
			for (int i = 0; i < collapsables.Length; i++)
				if (collapsables[i] == collapsable)
					return i;

			return -1;
		}
	}
}
