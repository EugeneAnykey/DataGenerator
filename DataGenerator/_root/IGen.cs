using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator
{
	public interface IGen<T>
	{
		T Generate();

		IEnumerable<T> Generate(int count);
	}
}
