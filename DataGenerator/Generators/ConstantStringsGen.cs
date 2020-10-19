using System.Collections.Generic;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class ConstantStringsGen : BaseGen, IGen<string>, IStringOutputer, IXmlable
	{
		// field
		public string Constant { get; private set; }

		public override string Name { get; set; } = "Constant String Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public ConstantStringsGen(string constant)
		{
			Constant = constant;
		}



		// Generate
		public string Generate() => Constant;

		public IEnumerable<string> Generate(int count) => Fill(count, () => Constant);



		// Output
		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = Fill(count, () => Constant) as string[];



		#region Xml
		public void WriteXmlSubtree(XmlWriter writer)
		{
			writer.WriteStartElement(XmlStrings.ConstantGen);
			writer.WriteAttributeString("name", Name);
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
							if (reader.MoveToAttribute("name"))
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
