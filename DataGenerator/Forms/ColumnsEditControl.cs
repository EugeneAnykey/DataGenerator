using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Project.DataGenerator.Misc;
using System;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class ColumnsEditControl : UserControl
	{
		// const
		readonly string[] exampleLines = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z".Split(',');
		

		// enum
		enum GeneratorsTypes { Nothing, Id, Integer, Double, String, FixedString, Unknown };

		// field
		GeneratorsTypes[] types = new GeneratorsTypes[(int)GeneratorsTypes.Unknown + 1];
		GeneratorsTypes selected = GeneratorsTypes.Unknown;
		Control[] paramControls;
		BaseGen gen;

		// init
		public ColumnsEditControl()
		{
			InitializeComponent();

			Init();
			InitEvent();
		}

		void Init()
		{
			paramControls = new Control[] {
				noParamsControl1,
				groupBoxIntsParams,
				groupBoxDoublesParams,
				groupBoxIdsParams,
				groupBoxFixedStrings
			};

			for (GeneratorsTypes type = GeneratorsTypes.Nothing; type <= GeneratorsTypes.Unknown; type++)
			{
				types[(int)type] = type;
			}

			comboBoxType.Items.Clear();
			for (int i = 0; i < types.Length; i++)
			{
				comboBoxType.Items.Add(types[i]);
			}
		}

		private void InitEvent()
		{
			comboBoxType.SelectedIndexChanged += (_, __) => PrepareGen();
			buttonAdd.Click += (_, __) => Add();
		}

		void Add()
		{
			if (selected == GeneratorsTypes.Unknown)
				return;

			switch (selected)
			{
				case GeneratorsTypes.Nothing:
					listBox1.Items.Add(new NothingGen());
					break;
				case GeneratorsTypes.Id:
					listBox1.Items.Add(idsParamsControl1.GetGen());
					break;
				case GeneratorsTypes.Integer:
					listBox1.Items.Add(intsParamsControl1.GetGen());
					break;
				case GeneratorsTypes.Double:
					listBox1.Items.Add(doublesParamsControl1.GetGen());
					break;
				case GeneratorsTypes.String:
					listBox1.Items.Add(fixedStringsParamsControl1.GetGen());
					break;
				case GeneratorsTypes.FixedString:
					listBox1.Items.Add(fixedStringsParamsControl1.GetFixedGen());
					break;
				case GeneratorsTypes.Unknown:
					break;
				default:
					break;
			}
		}


		// private
		void PrepareGen()
		{
			selected = (GeneratorsTypes)comboBoxType.SelectedIndex;

			switch (selected)
			{
				case GeneratorsTypes.Nothing:
					gen = new NothingGen();
					ShowNothing();
					break;
				case GeneratorsTypes.Id:
					gen = new IdsGen(1, 1);
					ShowId();
					break;
				case GeneratorsTypes.Integer:
					gen = new IntegersGen(1, 10);
					ShowInteger();
					break;
				case GeneratorsTypes.Double:
					gen = new DoublesGen(10, 20, 1);
					ShowDouble();
					break;
				case GeneratorsTypes.String:
					gen = new StringsGen(exampleLines);
					ShowString();
					break;
				case GeneratorsTypes.FixedString:
					gen = new FixedStringsGen(exampleLines, 3);
					ShowFixedString();
					break;
				case GeneratorsTypes.Unknown:
					gen = null;
					ShowUnknown();
					break;
				default:
					gen = new NothingGen();
					ShowUnknown();
					break;
			}

			textBoxName.Text = gen == null ? string.Empty : gen.Name;
		}



		// show
		void ShowNothing() { ShowOnlyThis(noParamsControl1); }

		void ShowId()
		{
			ShowOnlyThis(groupBoxIdsParams);
		}

		void ShowInteger()
		{
			ShowOnlyThis(groupBoxIntsParams);
		}

		void ShowDouble()
		{
			ShowOnlyThis(groupBoxDoublesParams);
		}

		void ShowString()
		{
			ShowOnlyThis(groupBoxFixedStrings);
			fixedStringsParamsControl1.MaxLengthEnabled = false;
		}

		void ShowFixedString()
		{
			ShowOnlyThis(groupBoxFixedStrings);
			fixedStringsParamsControl1.MaxLengthEnabled = true;
		}

		void ShowUnknown() { HideControls(); }



		#region controls
		void ShowOnlyThis(Control control)
		{
			foreach (var c in paramControls)
			{
				ToggleControl(c, c == control);
			}
		}

		void HideControls()
		{
			ToggleControl(groupBoxIntsParams, false);
			ToggleControl(groupBoxDoublesParams, false);
			ToggleControl(groupBoxIdsParams, false);
			ToggleControl(groupBoxFixedStrings, false);
		}

		void ToggleControl(Control control, bool enable)
		{
			if (control == null)
				return;

			control.Enabled = enable;
			control.Visible = enable;
		}
		#endregion
	}
}
