using System.Collections.Generic;

namespace EugeneAnykey.Project.DataGenerator
{
	public interface IStringOutputer
	{
		string[] Latest { get; }

		string Output();
		IEnumerable<string> Output(int count);
	}
}
