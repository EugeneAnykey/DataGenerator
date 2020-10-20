using System;
using System.Collections.Generic;
using System.Drawing;

namespace EugeneAnykey.Forms
{
	/// <summary>
	/// Color helper
	/// </summary>
	public class Colorer
	{
		#region fields and consts
		/// <summary>
		/// To make pale colors set it to true
		/// </summary>
		const bool pale = true;

		/// <summary>
		/// Maximum color value
		/// </summary>
		const byte max = 245;

		/// <summary>
		/// Minimum color value
		/// </summary>
		const byte bright = pale ? 220 : 192;

		// field
		readonly Random r = new Random((int)DateTime.Now.Millisecond);
		readonly List<Color> colors = new List<Color>();

		/// <summary>
		/// Possible colors values
		/// </summary>
		readonly byte[] colorValues = new byte[] { max, (max + bright) / 2, bright };

		/// <summary>
		/// Color to start from
		/// </summary>
		const byte initial = 0;

		/// <summary>
		/// Latest used color
		/// </summary>
		int latest = initial;
		#endregion

		#region init
		/// <summary>
		/// Initialize Color Helper
		/// </summary>
		public Colorer()
		{
			FillColors();
		}
		#endregion

		#region public
		/// <summary>
		/// Returns next possible color
		/// </summary>
		/// <returns>Next possible color</returns>
		public Color GetNext() {
			latest++;
			if (latest >= colors.Count)
				latest = initial;
			return colors[latest];
		}

		// inderxer
		public Color this[int index]
		{
			get {
				index = index < 0 ? 0 : colors.Count <= index ? colors.Count - 1 : index;
				return colors[index];
			}
		}

		/// <summary>
		/// Returns random possible color
		/// </summary>
		/// <returns>Random possible color</returns>
		public Color GetRandom()
		{
			return this[r.Next(colors.Count)];
		}
		#endregion

		#region private
		/// <summary>
		/// Returns Color by values
		/// </summary>
		/// <param name="r">Red</param>
		/// <param name="g">Green</param>
		/// <param name="b">Blue</param>
		/// <returns>Color</returns>
		Color GetColor(byte r, byte g, byte b) => Color.FromArgb(r, g, b);

		/// <summary>
		/// Generates colors
		/// </summary>
		void FillColors()
		{
			int times = colorValues.Length;

			for (byte r = 0; r < times; r++)
				for (byte g = 0; g < times; g++)
					for (byte b = 0; b < times; b++)
						colors.Add(GetColor(colorValues[r], colorValues[g], colorValues[b]));
		}
		#endregion
	}
}
