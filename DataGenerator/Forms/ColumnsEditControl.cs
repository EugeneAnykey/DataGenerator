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
				collapsableNoParams,
				collapsableIdsParams,
				collapsableIntsParams,
				collapsableDoublesParams,
				collapsableDates,
				collapsableStringsParams,
			};

			names = new[] {
				"",
				"Nothing",
				"Id",
				"Int",
				"Double",
				"Date",
				"String",
			};

			ugens = new UserControl[] {
				noParamsControl,
				idsParamsControl,
				intsParamsControl,
				doublesParamsControl,
				datesParamsControl,
				stringsParamsControl,
			};

			ShowOnly(collapsableNoParams);
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
			collapsableStringsParams.Caption = enable ? "Limited Strings Parameters" : "Strings Parameters";
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
			if (gen is NothingGen)
			{
				ActivateGen(collapsableNoParams, noParamsControl, gen);
				return;
			}

			if (gen is IdsGen)
			{
				ActivateGen(collapsableIdsParams, idsParamsControl, gen);
				return;
			}

			if (gen is IntegersGen)
			{
				ActivateGen(collapsableIntsParams, intsParamsControl, gen);
				return;
			}

			if (gen is DoublesGen)
			{
				ActivateGen(collapsableDoublesParams, doublesParamsControl, gen);
				return;
			}

			if (gen is DatesGen)
			{
				ActivateGen(collapsableDates, datesParamsControl, gen);
				return;
			}

			if (gen is StringsGen)
			{
				ActivateGen(collapsableStringsParams, stringsParamsControl, gen);
				stringsParamsControl.UseLimitedStrings = false;
				return;
			}

			if (gen is LimitedStringsGen)
			{
				ActivateGen(collapsableStringsParams, stringsParamsControl, gen);
				stringsParamsControl.UseLimitedStrings = true;
				return;
			}
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
