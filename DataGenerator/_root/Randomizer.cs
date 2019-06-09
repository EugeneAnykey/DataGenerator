using System;

namespace EugeneAnykey.Project.DataGenerator
{
	public static class Randomizer
	{
		public static Random R { get; } = new Random((int)DateTime.UtcNow.Ticks);
	}
}
