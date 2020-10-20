using System.Collections.Generic;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class ConstantStringsGen : BaseGen, IGen<string>, IStringOutputer, IXmlable
	{
		#region field
		public string Constant { get; private set; }

		public override string Name { get; set; } = "Constant String Gen";

		public string[] Latest { get; private set; } = new string[0];
		#endregion


		#region init
		public ConstantStringsGen(string constant)
		{
			Constant = constant;
		}
		#endregion


		#region public Generate, Output
		public string Generate() => Constant;

		public IEnumerable<string> Generate(int count) => Fill(count, () => Constant);

		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = Fill(count, () => Constant) as string[];
		#endregion


		#region Xml
		public void WriteXmlSubtree(XmlWriter writer)
		{
			writer.WriteStartElement(XmlStrings.ConstantGen);
			writer.WriteAttributeString(XmlStrings.NameAttr, Name);
			writer.WriteStartElement(XmlStrings.ParamsNode);
			writer.WriteAttributeString("constant", Constant);
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public void ReadXmlSubtree(XmlReader reader)
		{
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
				{
					if (reader.Name.Equals(XmlStrings.ConstantGen, Helpers.IgnoreCase))
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
							if (reader.MoveToAttribute("constant"))
								Constant = reader.Value;
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
