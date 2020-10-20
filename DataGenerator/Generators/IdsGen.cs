using System;
using System.Collections.Generic;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class IdsGen : BaseGen, IGen<int>, IStringOutputer, IXmlable
	{
		#region  field
		public override string Name { get; set; } = "Ids Gen";
		public int Start { get; private set; }
		public int Step { get; private set; }

		int current;
		public string[] Latest { get; private set; } = new string[0];
		#endregion


		#region init
		public IdsGen(int start, int step = 1)
		{
			Start = start;
			Step = step;
			current = start - step;
		}
		#endregion


		#region public: Generate, Output
		public int Generate() => current += Step;

		public IEnumerable<int> Generate(int count) => Fill(count, () => current += Step);

		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = Fill(count, () => (current += Step).ToString()) as string[];
		#endregion


		#region Xml
		public void WriteXmlSubtree(XmlWriter writer)
		{
			writer.WriteStartElement(XmlStrings.IdsGen);
			writer.WriteAttributeString("name", Name);
			writer.WriteStartElement(XmlStrings.ParamsNode);
			writer.WriteAttributeString("start", Start.ToString());
			writer.WriteAttributeString("step", Step.ToString());
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public void ReadXmlSubtree(XmlReader reader)
		{
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
				{
					if (reader.Name.Equals(XmlStrings.IdsGen, Helpers.IgnoreCase))
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
							if (reader.MoveToAttribute("start"))
								Start = Convert.ToInt32(reader.Value);
							if (reader.MoveToAttribute("step"))
								Step = Convert.ToInt32(reader.Value);
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
