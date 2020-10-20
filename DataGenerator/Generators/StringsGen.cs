using System;
using System.Collections.Generic;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class StringsGen : BaseGen, IGen<string>, IStringOutputer, IXmlable
	{
		#region field
		public override string Name { get; set; }
		public string[] Lines { get; private set; }
		public int StringLengthLimit { get; private set; }
		public bool Limited { get; private set; }
		int linesCount;

		public string[] Latest { get; private set; } = new string[0];
		#endregion


		#region init
		public StringsGen(string[] lines) : this(lines, 0) { }

		public StringsGen(string[] lines, int lengthLimit)
		{
			Init(lines);
			StringLengthLimit = lengthLimit > 0 ? lengthLimit : 0;
			Limited = StringLengthLimit > 0;
			Name = Limited ? "Limited Strings Gen" : "Strings Gen";
		}

		void Init(string[] lines)
		{
			Lines = lines;
			linesCount = lines.Length;
		}
		#endregion


		#region private: GetLimited
		string GetLimited(string s) => s.Length <= StringLengthLimit ? s : s.Substring(0, StringLengthLimit);
		#endregion


		#region public: Generate, Output
		public string Generate() => Limited ? GetLimited(Lines[R.Next(linesCount)]) : Lines[R.Next(linesCount)];

		public IEnumerable<string> Generate(int count) => Fill(count, () => Generate());

		public string Output() => Generate();

		public IEnumerable<string> Output(int count) => Latest = Fill(count, () => Generate()) as string[];
		#endregion


		#region Xml
		public void WriteXmlSubtree(XmlWriter writer)
		{
			writer.WriteStartElement(XmlStrings.StringsGen);
			writer.WriteAttributeString(XmlStrings.NameAttr, Name);
			writer.WriteStartElement(XmlStrings.ParamsNode);
			
			writer.WriteAttributeString("length_limited", StringLengthLimit.ToString());
			foreach (var s in Lines)
			{
				writer.WriteStartElement("lines");
				writer.WriteString(s);
				writer.WriteEndElement(); // lines
			}
			
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public void ReadXmlSubtree(XmlReader reader)
		{
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
				{
					if (reader.Name.Equals(XmlStrings.StringsGen, Helpers.IgnoreCase))
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
							if (reader.MoveToAttribute("length_limited"))
							{
								StringLengthLimit = Convert.ToInt32(reader.Value);
								Limited = StringLengthLimit > 0;
							}
						}
					}
					else if (reader.Name.Equals("lines", Helpers.IgnoreCase))
					{
						var list = new List<string>();
						while (reader.Read()) {
							// read lines
							if (reader.Name.Equals("line", Helpers.IgnoreCase))
								list.Add(reader.Value);
						}
						Init(list.ToArray());
					}
					else
						reader.Skip();
				}
			}
		}
		#endregion
	}
}
