using System;
using System.Collections.Generic;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class IntegersGen : BaseGen, IGen<int>, IStringOutputer, IXmlable
	{
		#region field
		public override string Name { get; set; } = "Integers Gen";
		public int Min { get; private set; }
		public int Max { get; private set; }

		public string[] Latest { get; private set; } = new string[0];
		#endregion


		#region init
		public IntegersGen(int min, int max)
		{
			Min = min;
			Max = max;
		}
		#endregion


		#region public: Generate, Output
		public int Generate() => R.Next(Min, Max + 1);

		public IEnumerable<int> Generate(int count) => Fill<int>(count, () => Generate());

		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => Generate().ToString())) as string[];
		#endregion


		#region Xml
		public void WriteXmlSubtree(XmlWriter writer)
		{
			writer.WriteStartElement(XmlStrings.IntegersGen);
			writer.WriteAttributeString(XmlStrings.NameAttr, Name);
			writer.WriteStartElement(XmlStrings.ParamsNode);
			writer.WriteAttributeString("min", Min.ToString());
			writer.WriteAttributeString("max", Max.ToString());
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public void ReadXmlSubtree(XmlReader reader)
		{
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
				{
					if (reader.Name.Equals(XmlStrings.IntegersGen, Helpers.IgnoreCase))
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
							if (reader.MoveToAttribute("min"))
								Min = Convert.ToInt32(reader.Value);
							if (reader.MoveToAttribute("max"))
								Max = Convert.ToInt32(reader.Value);
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
