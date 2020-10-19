using System.Xml;

namespace EugeneAnykey.Project.DataGenerator
{
	public interface IXmlable
	{
		void WriteXmlSubtree(XmlWriter writer);
		void ReadXmlSubtree(XmlReader reader);
	}
}
