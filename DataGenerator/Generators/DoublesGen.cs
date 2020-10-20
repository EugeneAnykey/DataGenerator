using System;
using System.Collections.Generic;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class DoublesGen : BaseGen, IGen<double>, IStringOutputer, IXmlable
	{
		#region field
		public int Min { get; private set; }
		public int Max { get; private set; }
		public int Decimals { get; private set; }

		readonly double divisor;

		public override string Name { get; set; } = "Doubles Gen";

		public string[] Latest { get; private set; } = new string[0];
		#endregion


		#region init
		public DoublesGen(int min, int max, int decimals)
		{
			Min = min;
			Max = max;
			Decimals = decimals;
			divisor = Math.Pow(10, decimals);
		}
		#endregion


		#region public Generate, Output
		public double Generate() => R.Next(Min, Max) / divisor;

		public IEnumerable<double> Generate(int count) => Fill<double>(count, () => R.Next(Min, Max));

		public string Output() => Generate().ToString();

		public IEnumerable<string> Output(int count) => Latest = (Fill<string>(count, () => (R.Next(Min, Max) / divisor).ToString())) as string[];
		#endregion


		#region Xml
		public void WriteXmlSubtree(XmlWriter writer)
		{
			writer.WriteStartElement(XmlStrings.DoublesGen);
			writer.WriteAttributeString(XmlStrings.NameAttr, Name);
			writer.WriteStartElement(XmlStrings.ParamsNode);
			writer.WriteAttributeString("min", Min.ToString());
			writer.WriteAttributeString("max", Max.ToString());
			writer.WriteAttributeString("decimals", Decimals.ToString());
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public void ReadXmlSubtree(XmlReader reader)
		{
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
				{
					if (reader.Name.Equals(XmlStrings.DoublesGen, Helpers.IgnoreCase))
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
							if (reader.MoveToAttribute("decimals"))
								Decimals = Convert.ToInt32(reader.Value);
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
