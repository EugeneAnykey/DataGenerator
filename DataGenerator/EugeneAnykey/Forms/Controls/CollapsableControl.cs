using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EugeneAnykey.Forms.Controls
{
	/// <summary>
	/// It is a Windows control that displays a border around a few of controls with an optional caption on top/left side.
	/// </summary>
	[Designer(typeof(Designers.MyControlDesigner))]
	[DefaultEvent("HeightChanged"), DefaultProperty("Collapsed"), ToolboxItemFilter("EugeneAnykey.Forms.Controls")]
	public partial class CollapsableControl : UserControl
	{
		const string NoTextCaption = "No caption";



		#region event: HeightChanged, WidthChanged.
		/// <summary>
		/// Event raised when height changed.
		/// </summary>
		[Category("Property Changed")]
		[Description("Event raised when height of the control changed.")]
		public event EventHandler HeightChanged;
		protected virtual void OnHeightChanged() => HeightChanged?.Invoke(this, EventArgs.Empty);



		/// <summary>
		/// Event raised when width changed.
		/// </summary>
		[Category("Property Changed")]
		[Description("Event raised when width of the control changed.")]
		public event EventHandler WidthChanged;
		protected virtual void OnWidthChanged() => WidthChanged?.Invoke(this, EventArgs.Empty);



		/// <summary>
		/// Event raised when width changed.
		/// </summary>
		[Category("Property Changed")]
		[Description("Event raised when Collapsed is set.")]
		public event EventHandler CollapseStateChanged;
		void OnCollapseStateChanged() => CollapseStateChanged?.Invoke(this, EventArgs.Empty);
		#endregion



		#region field: [BackColor], BaseColor, SetColors.
		/// <summary>
		/// Panel color.
		/// </summary>
		[Category("Appearance")]
		[Description("Panel color.")]
		public Color BaseColor
		{
			get { return workingPanel.BackColor; }
			set { workingPanel.BackColor = value; }
		}

		/// <summary>
		/// Sets border and panel colors.
		/// </summary>
		/// <param name="border">Border (back) color.</param>
		/// <param name="panel">Panel (front) color.</param>
		public void SetColors(Color border, Color panel)
		{
			BackColor = border;
			BaseColor = panel;
		}
		#endregion



		#region field: Caption, CaptionCollapsed.
		string caption = string.Empty;
		/// <summary>
		/// Control text caption
		/// </summary>
		[Category("Appearance")]
		[Description("Control text caption.")]
		public string Caption
		{
			get { return caption; }
			set
			{
				caption = string.IsNullOrEmpty(value) ? NoTextCaption : value;
				SetControlTextCaption();
			}
		}

		string captionCollapsed = string.Empty;
		/// <summary>
		/// Text caption shown when control collapsed
		/// </summary>
		[Category("Appearance")]
		[Description("Text caption shown when control collapsed.")]
		public string CaptionCollapsed
		{
			get { return captionCollapsed; }
			set { captionCollapsed = value ?? string.Empty; }
		}

		void SetControlTextCaption()
		{
			Label acceptor = verticalOrientation ? labelVer : labelHor;
			acceptor.Text =
				collapsed && !string.IsNullOrEmpty(captionCollapsed) ?
				captionCollapsed : Caption;
		}
		#endregion



		#region field: Collapsable, Collapsed, VerticalOrientation, WorkingArea.
		bool collapsable;
		/// <summary>
		/// Determines whether control could be collapsed
		/// </summary>
		[Category("Appearance")]
		[Description("Determines whether control could be collapsed.")]
		public bool Collapsable
		{
			get { return collapsable; }
			set
			{
				if (!(collapsable = value))
					Collapsed = false;
			}
		}

		bool collapsed = false;
		/// <summary>
		/// Collapsed state
		/// </summary>
		[Category("Appearance")]
		[Description("Collapsed state.")]
		public bool Collapsed
		{
			get { return collapsed; }
			set
			{
				if (Collapsable)
					ShowWithState(collapsed = value, false);
			}
		}

		bool verticalOrientation = false;

		Orientation controlOrientation;
		/// <summary>
		/// Control orientation
		/// </summary>
		[Category("Appearance")]
		[Description("Control orientation.")]
		public Orientation ControlOrientation
		{
			get { return controlOrientation; }
			set
			{
				bool oriChanged = controlOrientation != value;

				verticalOrientation = (controlOrientation = value) == Orientation.Vertical;
				labelHor.Visible = !(labelVer.Visible = verticalOrientation);
				ShowWithState(collapsed, oriChanged);
			}
		}

		bool captionOppositeAlignment;
		/// <summary>
		/// Caption opposite position (bottom or right instead of top or left)
		/// </summary>
		[Category("Appearance")]
		[Description("Caption opposite position (bottom or right instead of top or left).")]
		public bool CaptionOppositeAlignment
		{
			get { return captionOppositeAlignment; }
			set
			{
				if (captionOppositeAlignment != value)
				{
					captionOppositeAlignment = value;

					labelHor.Dock = captionOppositeAlignment ? DockStyle.Bottom : DockStyle.Top;
					labelVer.Dock = captionOppositeAlignment ? DockStyle.Right : DockStyle.Left;
				}
			}
		}

		/// <summary>
		/// Acceptor for your controls
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Category("Design")]
		[Description("Acceptor for your controls.")]
		public Panel WorkingArea { get { return this.workingPanel; } }
		#endregion



		#region init
		/// <summary>
		/// Constructor.
		/// </summary>
		public CollapsableControl()
		{
			InitializeComponent();
			// init:
			normalHeight = workingPanel.Height;
			normalWidth = workingPanel.Width;
			captionOppositeAlignment = false;
			collapsed = false;
			Collapsable = true;
			// events:
			this.Click += (_, __) => ToggleCollapse();
			this.labelHor.Click += (_, __) => ToggleCollapse();
			this.labelVer.Click += (_, __) => ToggleCollapse();
			this.SizeChanged += RecalcSizes;
		}
		#endregion



		#region private: RecalcSizes, ShowWithState, ToggleCollapse.
		int addh = 2;
		int addw = 2;
		int normalHeight;
		int normalWidth;

		/// <summary>
		/// Calculating 
		/// </summary>
		void RecalcSizes(object sender, EventArgs e)
		{
			if (workingPanel.Visible)
			{
				addw = Width - (normalWidth = workingPanel.Width);
				addh = Height - (normalHeight = workingPanel.Height);
			}
		}



		/// <summary>
		/// Resizing control and prepairing its visuals.
		/// </summary>
		/// <param name="_collapsed">wanted state (would not work on not collapsable)</param>
		/// <param name="orientationChanged">true, if orientation had changed</param>
		void ShowWithState(bool _collapsed, bool orientationChanged)
		{
			SetControlTextCaption();
			RecalcSizes(null, EventArgs.Empty);
			bool isCollapsedForSure = _collapsed && collapsable;
			workingPanel.Visible = !isCollapsedForSure;

			int oriw = 0, orih = 0;
			if (orientationChanged && collapsable && _collapsed)
			{
				oriw = labelVer.Visible ? labelVer.Width : 0;
				orih = labelHor.Visible ? labelHor.Height : 0;
			}

			SizeChanged -= RecalcSizes;
			Size = new Size(
				oriw + addw + (isCollapsedForSure && verticalOrientation ? 0 : normalWidth),
				orih + addh + (isCollapsedForSure && !verticalOrientation ? 0 : normalHeight)
				);
			SizeChanged += RecalcSizes;

			if (verticalOrientation)
			{
				OnWidthChanged();
			}
			else
			{
				OnHeightChanged();
			}
		}



		/// <summary>
		/// Toggles collapsed state
		/// </summary>
		void ToggleCollapse()
		{
			if (Collapsable)
			{
				Collapsed = !Collapsed;
				OnCollapseStateChanged();
			}
		}
		#endregion
	}
}
