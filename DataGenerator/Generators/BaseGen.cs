using System;
using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public abstract class BaseGen
	{
		// field
		public static Random R { get; } = new Random((int)DateTime.UtcNow.Ticks);

		public virtual string Name { get; set; } = "BaseGen";



		// private: Fill.
		protected IEnumerable<T> Fill<T>(int count, Func<T> gen)
		{
			if (count < 0)
				throw new ArgumentException("Should be more than 0");

			var res = new T[count];

			for (int i = 0; i < count; i++)
			{
				res[i] = gen();
			}

			return res;
		}



		// ToString
		public override string ToString() => Name;
	}
}
