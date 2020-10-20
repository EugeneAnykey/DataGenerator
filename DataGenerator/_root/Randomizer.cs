using System;

namespace EugeneAnykey.Project.DataGenerator
{
	public static class Randomizer
	{
		public static Random R { get; } = new Random((int)DateTime.UtcNow.Ticks);

		public static string OneOf(string[] lines) => lines[R.Next(lines.Length)];
		public static T OneOf<T>(T[] lines) => lines[R.Next(lines.Length)];
	}
}
