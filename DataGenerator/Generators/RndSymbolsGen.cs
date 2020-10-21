using System;
using System.Collections.Generic;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class RndSymbolsGen : BaseGen, IGen<string>, IStringOutputer, IXmlable
	{
		#region const
		const int MaxPossibleLength = 65000;
		#endregion


		#region field
		public string[] Lines { get; set; }
		public int MinLength { get; private set; }
		public int MaxLength { get; private set; }
		//public int AvgLength { get; }

		public string AdditionalSymbols { get; private set; }
		
		public string Line { get; private set; }
		public int SymbolsCount { get; private set; }

		public override string Name { get; set; } = "Random Symbols Gen";
		public string[] Latest { get; private set; } = new string[0];
		#endregion


		#region init
		public RndSymbolsGen(string[] lines, int min = 0, int max = 1000)
		{
			MinLength = min > 0 ? min : 0;
			MaxLength = max > 0 ? (max < MaxPossibleLength ? max : MaxPossibleLength) : 0;
			//AvgLength = (min + max) / 2;
			Init(lines);
		}

		void Init(string[] lines)
		{
			Lines = lines;
			Line = string.Concat(lines);
			SymbolsCount = Line.Length;
			AdditionalSymbols = lines[lines.Length - 1];
		}
		#endregion


		#region public: Generate, Output
		public string Generate()
		{
			if (SymbolsCount == 0)
				return string.Empty;

			var len = R.Next(MinLength, MaxLength + 1);
			var chars = new char[len];
			for (int i = 0; i < len; i++)
			{
				chars[i] = Line[R.Next(SymbolsCount)];
			}
			string res = new string(chars);
			return res;
		}

		public IEnumerable<string> Generate(int count) => Fill(count, () => Generate());

		public string Output() => Generate();

		public IEnumerable<string> Output(int count) => Latest = Fill(count, () => Generate()) as string[];
		#endregion


		#region Xml
		public void WriteXmlSubtree(XmlWriter writer)
		{
			writer.WriteStartElement(XmlStrings.RndSymbolsGen);
			writer.WriteAttributeString(XmlStrings.NameAttr, Name);
			writer.WriteStartElement(XmlStrings.ParamsNode);
			writer.WriteAttributeString("min", MinLength.ToString());
			writer.WriteAttributeString("max", MaxLength.ToString());

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
			var list = new List<string>();
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
				{
					if (reader.Name.Equals(XmlStrings.RndSymbolsGen, Helpers.IgnoreCase))
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
								MinLength = Convert.ToInt32(reader.Value);
							if (reader.MoveToAttribute("max"))
								MaxLength = Convert.ToInt32(reader.Value);
						}
					}
					else if (reader.Name.Equals("lines", Helpers.IgnoreCase))
					{
						if (reader.Read())
						{
							if (reader.NodeType == XmlNodeType.Text)
								list.Add(reader.Value);
							else list.Add("");
						}
					}
					else
						reader.Skip();
				}
			}
			Init(list.ToArray());
		}
		#endregion
	}
}
