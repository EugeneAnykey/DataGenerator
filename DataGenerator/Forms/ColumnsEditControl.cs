using EugeneAnykey.Project.DataGenerator.Generators;
using EugeneAnykey.Project.DataGenerator.Misc;
using System;
using System.Windows.Forms;

namespace EugeneAnykey.Project.DataGenerator.Forms
{
	public partial class ColumnsEditControl : UserControl
	{
		// enum
		enum GeneratorsTypes { Nothing, Id, Integer, Double, String, FixedString, Unknown };

		// field
		GeneratorsTypes[] types = new GeneratorsTypes[(int)GeneratorsTypes.Unknown + 1];
		GeneratorsTypes selected = GeneratorsTypes.Unknown;
		Control[] groupBoxes;

		// init
		public ColumnsEditControl()
		{
			InitializeComponent();

			Init();
			InitEvent();
		}

		void Init()
		{
			groupBoxes = new[] {
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
		}

		readonly string[] exampleLines = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z".Split(',');
		BaseGen gen;

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
		void ShowNothing() { HideControls(); }

		void ShowId()
		{
			ShowOnlyControls(groupBoxIdsParams);
		}

		void ShowInteger()
		{
			ShowOnlyControls(groupBoxIntsParams);
		}

		void ShowDouble()
		{
			ShowOnlyControls(groupBoxDoublesParams);
		}

		void ShowString()
		{
			ShowOnlyControls(groupBoxFixedStrings);
			fixedStringsParamsControl1.MaxLengthEnabled = false;
		}

		void ShowFixedString()
		{
			ShowOnlyControls(groupBoxFixedStrings);
			fixedStringsParamsControl1.MaxLengthEnabled = true;
		}

		void ShowUnknown() { HideControls(); }




		#region controls
		void ShowOnlyControls(Control control)
		{
			foreach (var c in groupBoxes)
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
