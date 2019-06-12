using System.Windows.Forms;
using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Forms.Controls;

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
				noParamsControl1,
				idsParamsControl1,
				intsParamsControl1,
				doublesParamsControl1,
				fixedStringsParamsControl1
			};

			ShowOnly(collapsableNoParams);
		}

		void InitEvent()
		{
			buttonAdd.Click += (_, __) => Add();

			foreach (var col in collapsables)
			{
				col.CollapseStateChanged += (_, __) => ShowOnly(col);
			}

			checkBoxLimitedStrings.CheckedChanged += (_, __) => ToggleLimitedStrings(checkBoxLimitedStrings.Checked);
		}



		void ToggleLimitedStrings(bool enable)
		{
			collapsableStringsParams.Caption = enable ? "Limited Strings Parameters" : "Strings Parameters";
			fixedStringsParamsControl1.UseLimitedStrings = enable;
		}

		void Add()
		{
			BaseGen gen = null;

			gen = new NothingGen();
			gen = idsParamsControl1.GetGen();
			gen = intsParamsControl1.GetGen();
			gen = doublesParamsControl1.GetGen();
			//case GeneratorsTypes.String:
			gen = fixedStringsParamsControl1.GetGen();
			//case GeneratorsTypes.FixedString:
			gen = fixedStringsParamsControl1.GetGen();
			//case GeneratorsTypes.Unknown:
			//default:
			//gen = null;

			if (gen == null)
				return;

			gen.Name = textBoxName.Text;
			listBox1.Items.Add(gen);
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
