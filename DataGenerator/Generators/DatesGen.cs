using System;
using System.Collections.Generic;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class DatesGen : BaseGen, IGen<DateTime>, IStringOutputer, IXmlable
	{
		/* mask
		 yyyy-MM-dd - 2019-06-20
		 HH:mm:ss - 18:28:38 (hh for am/pm variant: 6 pm)
		 */
		const string defaultFormat = "yyyy-MM-dd";



		// field
		public DateTime Min { get; private set; }
		public DateTime Max { get; private set; }
		public string Format { get; private set; }

		readonly long dif;



		public override string Name { get; set; } = "Dates Gen";

		public string[] Latest { get; private set; } = new string[0];



		// init
		public DatesGen(DateTime min, DateTime max) : this(min, max, defaultFormat) { }

		public DatesGen(DateTime min, DateTime max, string format)
		{
			Format = format ?? defaultFormat;
			Min = min;
			Max = max;
			dif = max.Ticks - min.Ticks;
		}



		// Generate
		public DateTime Generate() => new DateTime((long)(R.NextDouble() * dif) + Min.Ticks);

		public IEnumerable<DateTime> Generate(int count) => Fill(count, () => Generate());



		// Output
		public string Output() => Generate().ToString(Format);

		public IEnumerable<string> Output(int count) => Latest = Fill(count, () => Generate().ToString(Format)) as string[];


		#region Xml
		public void WriteXmlSubtree(XmlWriter writer)
		{
			writer.WriteStartElement(XmlStrings.DatesGen);
			writer.WriteAttributeString("name", Name);
			writer.WriteStartElement(XmlStrings.ParamsNode);
			writer.WriteAttributeString("min", Min.ToBinary().ToString());
			writer.WriteAttributeString("max", Max.ToBinary().ToString());
			writer.WriteAttributeString("format", Format);
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public void ReadXmlSubtree(XmlReader reader)
		{
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
				{
					if (reader.Name.Equals(XmlStrings.DatesGen, Helpers.IgnoreCase))
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
							if (reader.MoveToAttribute("min"))
								Min = DateTime.FromBinary(Convert.ToInt64(reader.Value));
							if (reader.MoveToAttribute("max"))
								Max = DateTime.FromBinary(Convert.ToInt64(reader.Value));
							if (reader.MoveToAttribute("format"))
								Format = reader.Value;
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
