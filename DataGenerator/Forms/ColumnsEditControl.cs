using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Forms.Controls;
using System;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class ColumnsEditControl : UserControl
	{
		// const
		readonly string[] exampleLines = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z".Split(',');



		// field
		//BaseGen gen;

		UserControl[] gens;
		CollapsableControl[] collapsables;

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
				collapsableStringsParams
			};

			gens = new UserControl[] {
				noParamsControl,
				idsParamsControl,
				intsParamsControl,
				doublesParamsControl,
				stringsParamsControl
			};

			ShowOnly(collapsableNoParams);
		}

		void InitEvent()
		{
			gensListControl1.AddingItem += (_, gen) => AddingItem(gen);

			foreach (var col in collapsables)
			{
				col.CollapseStateChanged += (_, __) => ShowOnly(col);
			}

			checkBoxLimitedStrings.CheckedChanged += (_, __) => ToggleLimitedStrings(checkBoxLimitedStrings.Checked);
		}

		void AddingItem(GenItemAddEventArgs genItemArgs)
		{
			IGenGetter ugen = null;
			for (int i = 0; i < collapsables.Length; i++)
			{
				if (!collapsables[i].Collapsed)
				{
					ugen = gens[i] as IGenGetter;
					break;
				}
			}

			genItemArgs.Gen = ugen?.GetBaseGen();
		}

		void ToggleLimitedStrings(bool enable)
		{
			collapsableStringsParams.Caption = enable ? "Limited Strings Parameters" : "Strings Parameters";
			stringsParamsControl.UseLimitedStrings = enable;
		}

		void Add()
		{
			BaseGen gen = null;

			gen = new NothingGen();
			gen = idsParamsControl.GetGen();
			gen = intsParamsControl.GetGen();
			gen = doublesParamsControl.GetGen();
			//case GeneratorsTypes.String:
			gen = stringsParamsControl.GetGen();
			//case GeneratorsTypes.FixedString:
			gen = stringsParamsControl.GetGen();
			//case GeneratorsTypes.Unknown:
			//default:
			//gen = null;

			if (gen == null)
				return;

			gen.Name = textBoxName.Text;
			//listBox.Items.Add(gen);
		}



		void ShowOnly(CollapsableControl collapsable)
		{
			foreach (var c in collapsables)
			{
				c.Collapsed = !(c == collapsable);
			}

			if (null == collapsable)
			{
				textBoxName.Text = "";
				return;
			}

			if (textBoxName.Text.Length == 0)
			{
				textBoxName.Text = collapsable.Caption;
			}
		}
	}
}
