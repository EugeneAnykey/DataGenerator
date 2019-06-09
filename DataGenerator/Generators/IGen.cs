using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public interface IGen<T>
	{
		T Generate();
		//T[] Generate(int count);
		IEnumerable<T> Generate(int count);
	}
}
