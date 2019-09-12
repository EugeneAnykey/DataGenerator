using System;
using System.Collections.Generic;
using System.Drawing;

namespace EugeneAnykey.Forms
{
	public class Colorer
	{
		// const
		const bool pale = true;

		const int max = 245;
		const int bright = pale ? 220 : 192;
		const int semi = (max + bright) / 2;



		// field
		readonly Random r = new Random((int)DateTime.Now.Millisecond);

		List<Color> colors = new List<Color>();

		readonly int[] colorValues = new[] { max, semi, bright };
		readonly int colorsGraduationCount;



		// current
		const int initial = 0;
		int current = initial;

		public Color GetNext() {
			current++;
			if (current >= colors.Count)
				current = initial;
			return colors[current];
		}

		// inderxer
		public Color this[int index]
		{
			get {
				index = index < 0 ? 0 : colors.Count <= index ? colors.Count - 1 : index;
				return colors[index];
			}
		}

		public Color Random()
		{
			return this[r.Next(colors.Count)];
		}



		// init
		public Colorer()
		{
			colorsGraduationCount = colorValues.Length;
			FillColors();
		}



		// private
		Color SetColor(int r, int g, int b) => Color.FromArgb(r, g, b);

		void FillColors()
		{
			int times = colorValues.Length;

			int r = 0;
			while (r < times)
			{
				int g = 0;
				while (g < times)
				{
					int b = 0;
					while (b < times)
					{
						//if (b == g && b == r)
						//	continue;
						colors.Add(SetColor(colorValues[r], colorValues[g], colorValues[b]));
						b++;
					}
					g++;
				}
				r++;
			}
		}
	}
}
