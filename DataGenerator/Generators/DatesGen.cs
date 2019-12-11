using System;
using System.Collections.Generic;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class DatesGen : BaseGen, IGen<DateTime>, IStringOutputer, IXmlOutputer
	{
		/* mask
		 yyyy-MM-dd - 2019-06-20
		 HH:mm:ss - 18:28:38 (hh for am/pm variant: 6 pm)
		 */
		const string defaultFormat = "yyyy-MM-dd";



		// field
		public DateTime Min { get; }
		public DateTime Max { get; }
		public string Format { get; }

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



		// Xml
		public void WriteXmlSubtree(XmlWriter writer)
		{
			//writer.WriteStartElement("DatesGen");
			writer.WriteAttributeString("Min", Min.ToBinary().ToString());
			writer.WriteAttributeString("Max", Max.ToBinary().ToString());
			writer.WriteAttributeString("Format", Format);
			//writer.WriteFullEndElement();
		}
	}
}
