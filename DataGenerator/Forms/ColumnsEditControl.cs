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
		GeneratorsTypes[] types = new GeneratorsTypes[(int)GeneratorsTypes.Unknown];
		GeneratorsTypes selected = GeneratorsTypes.Unknown;

		// init
		public ColumnsEditControl()
		{
			InitializeComponent();

			Init();
			InitEvent();
		}

		void Init()
		{
			for (GeneratorsTypes type = GeneratorsTypes.Nothing; type < GeneratorsTypes.Unknown; type++)
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
					break;
				case GeneratorsTypes.Id:
					gen = new IdsGen(1, 1);
					break;
				case GeneratorsTypes.Integer:
					gen = new IntegersGen(1, 10);
					break;
				case GeneratorsTypes.Double:
					gen = new DoublesGen(10, 20, 1);
					break;
				case GeneratorsTypes.String:
					gen = new StringsGen(exampleLines);
					break;
				case GeneratorsTypes.FixedString:
					gen = new FixedStringsGen(exampleLines, 3);
					break;
				case GeneratorsTypes.Unknown:
					gen = null;
					break;
				default:
					gen = new NothingGen();
					break;
			}

			textBoxName.Text = gen.Name;
			HideControls();
		}



		// show
		void ShowNothing() { }

		void ShowId()
		{
			ToggleControl(groupBoxIdsParams, true);
		}

		void ShowInteger()
		{
			ToggleControl(groupBoxIntsParams, true);
		}

		void ShowDouble()
		{
			ToggleControl(groupBoxDoublesParams, true);
		}

		void ShowString()
		{

		}

		void ShowFixedString()
		{

		}

		void ShowUnknown() { }

		#region controls
		void HideControls()
		{
			ToggleControl(groupBoxIntsParams, false);
			ToggleControl(groupBoxDoublesParams, false);
			ToggleControl(groupBoxIdsParams, false);
		}

		void ToggleControl(Control control, bool enable)
		{
			control.Enabled = enable;
			control.Visible = enable;
		}


		#endregion
	}
}
