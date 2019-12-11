using System;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.IO
{
	public class SchemeGen
	{

		public static void WriteXmlSubtree(XmlWriter writer)
		{
			if (writer == null)
				throw new ArgumentNullException("writer");

			var name = "";
			var param = "";

			writer.WriteStartElement("Generator");
			writer.WriteAttributeString("name", name);
			writer.WriteAttributeString("param", param);
			writer.WriteFullEndElement();
		}

		//public static void WriteXmlSubtree(XmlWriter writer)
		//{
		//	if (writer == null)
		//		throw new ArgumentNullException("writer");

		//	// rune base:
		//	writer.WriteStartElement(XmlStrings.XmlRune);
		//	writer.WriteAttributeString("name", rune.Name);
		//	writer.WriteAttributeString("id", Convert.ToString(rune.Index));
		//	writer.WriteAttributeString("type", rune.Type.ToString());
		//	writer.WriteAttributeString("slot", Convert.ToString(rune.Slot));
		//	writer.WriteAttributeString("level", Convert.ToString(rune.Level));
		//	writer.WriteAttributeString("stars", Convert.ToString(rune.Stars));

		//	// rune bonuses (advanced inline):
		//	writer.WriteStartElement("Bonus");
		//	writer.WriteAttributeString("main", rune.MainStat.Output());
		//	writer.WriteAttributeString("sub", rune.Sub_Stat.Output());
		//	writer.WriteAttributeString("add1", rune.Add1Stat.Output());
		//	writer.WriteAttributeString("add2", rune.Add2Stat.Output());
		//	writer.WriteAttributeString("add3", rune.Add3Stat.Output());
		//	writer.WriteAttributeString("add4", rune.Add4Stat.Output());
		//	writer.WriteEndElement();   // Bonus

		//	writer.WriteFullEndElement();   // Rune
		//}

	}
}
