using System.Collections.Generic;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class NothingGen : BaseGen, IGen<string>, IStringOutputer, IXmlable
	{
		#region field
		public override string Name { get; set; } = "Nothing Gen";

		public string[] Latest { get; private set; } = new string[0];
		#endregion


		#region init
		public NothingGen() { }
		#endregion


		#region public: Generate, Output
		public string Generate() => string.Empty;

		public IEnumerable<string> Generate(int count) => Fill<string>(count, () => string.Empty);

		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = Fill<string>(count, () => string.Empty) as string[];
		#endregion


		#region Xml
		public void WriteXmlSubtree(XmlWriter writer)
		{
			writer.WriteStartElement(XmlStrings.NothingGen);
			writer.WriteAttributeString(XmlStrings.NameAttr, Name);
			writer.WriteStartElement(XmlStrings.ParamsNode);
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public void ReadXmlSubtree(XmlReader reader)
		{
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
				{
					if (reader.Name.Equals(XmlStrings.NothingGen, Helpers.IgnoreCase))
					{
						if (reader.HasAttributes)
						{
							if (reader.MoveToAttribute(XmlStrings.NameAttr))
								Name = reader.Value;
						}
					}
					else if (reader.Name.Equals(XmlStrings.ParamsNode, Helpers.IgnoreCase))
					{
						if (reader.HasAttributes)
						{
						}
					}
					else
						reader.Skip();
				}
			}
		}
		#endregion
	}
}
