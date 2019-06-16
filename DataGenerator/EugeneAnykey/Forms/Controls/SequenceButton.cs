using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EugeneAnykey.Forms.Controls
{
	[DefaultEvent("PositionChanged"), DefaultProperty("Position"), ToolboxItemFilter("EugeneAnykey.Forms.Controls")]
	public class SequenceButton : Button
	{
		// event: PositionChanged.
		[Category("Property Changed")]
		[Description("Event raised when value position is changed.")]
		public event EventHandler ValuePositionChanged;
		void OnValuePositionChanged() => ValuePositionChanged?.Invoke(this, EventArgs.Empty);



		// field: max, min, NoValue.
		int max = -1;
		int min = -1;

		protected string NoValue;
		protected string NoValues;



		bool indefiniteState;
		[Category("Input")]
		[Description("Sets the indefinite state to show or hide.")]
		public bool UndefiniteState
		{
			get { return indefiniteState; }
			set
			{
				indefiniteState = value;
				SetMin();
			}
		}



		string[] values;
		[Category("Input")]
		[Description("The possible values to check.")]
		public string[] Values
		{
			get { return values; }
			set
			{
				values = value ?? new[] { NoValues };
				max = values.Length - 1;
				SetMin();
			}
		}



		int valuePosition = -1;
		/// <summary>
		/// Determines the value's index in the values array.
		/// </summary>
		[Category("Input")]
		[Description("Determines the value's index in the values array.")]
		public int ValuePosition
		{
			get { return valuePosition; }
			set
			{
				if (valuePosition != value)
				{
					valuePosition = Cycling(value, min, max);
					OnValuePositionChanged();
				}
				// Show next label...
				Text = (values != null && 0 <= valuePosition && valuePosition < values.Length) ? values[valuePosition] : NoValue;
			}
		}



		// init
		public SequenceButton()
		{
			NoValue = "undefinite";
			NoValues = "!No values!";

			this.Click += (_, __) => Clicked();
		}



		// private: Clicked, Cycling, SetMin.
		void Clicked()
		{
			bool forward = ModifierKeys != Keys.Shift;
			ValuePosition = valuePosition + (forward ? 1 : -1);
		}

		static int Cycling(int index, int min, int max) => index >= 0 ? (index > max ? min : index) : max;

		void SetMin() => ValuePosition = min = indefiniteState ? -1 : 0;
	}
}