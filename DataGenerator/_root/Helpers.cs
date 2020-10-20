using System;

namespace EugeneAnykey.Project.DataGenerator
{
	public static class Helpers
	{
		public const StringComparison IgnoreCase = StringComparison.InvariantCultureIgnoreCase;

		public static bool IsIn(int val, int min, int max) => min <= val && val <= max;

		public static int MakeIn(int val, int min, int max) => min > val ? min : val > max ? max : val;
	}
}
