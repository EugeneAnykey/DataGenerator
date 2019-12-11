using System.Xml;

namespace EugeneAnykey.Project.DataGenerator
{
	public interface IXmlOutputer
	{
		void WriteXmlSubtree(XmlWriter writer);
	}
}
