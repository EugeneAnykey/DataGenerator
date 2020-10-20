using System.Collections.Generic;
using System.Xml;

namespace EugeneAnykey.Project.DataGenerator.Generators
{
	public class MaskedIdsGen : BaseGen, IGen<string>, IStringOutputer, IXmlable
	{
		#region const
		const string predefDigits = "0123456789";
		const string predefLatin = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		const string predefRus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЪЫЭЮЯ";
		const string predefAutos = "ABCEHKMNOPTXY";
		const string predefHex = "0123456789abcdef";
		#endregion


		#region field
		public override string Name { get; set; } = "Masked Ids Gen";
		public string Mask { get; private set; }
		readonly char[] symbols;

		public string[] Latest { get; private set; } = new string[0];
		#endregion


		#region init
		public MaskedIdsGen(string mask)
		{
			Mask = mask;
			symbols = mask.ToCharArray();
		}
		#endregion


		#region public: Generate, Output
		public string Generate()
		{
			// helpers
			char OneOf(string s) => s[R.Next(s.Length)];

			char[] res = new char[symbols.Length];
			symbols.CopyTo(res, 0);
			
			for (int i = 0; i < res.Length; i++)
			{
				char replace =
					res[i] == MaskHolder.PredefMaskDigit? OneOf(predefDigits) :
					res[i] == MaskHolder.PredefMaskAutos ? OneOf(predefAutos) :
					res[i] == MaskHolder.PredefMaskHex ? OneOf(predefHex) :
					res[i] == MaskHolder.PredefMaskLatin ? OneOf(predefLatin) :
					res[i] == MaskHolder.PredefMaskRus ? OneOf(predefRus) :
					res[i];

				if (replace != res[i])
					res[i] = replace;
			}

			return new string(res);
		}

		public IEnumerable<string> Generate(int count) => Fill(count, () => Generate());

		public string Output() => Generate();

		public IEnumerable<string> Output(int count) => Latest = Generate(count) as string[];
		#endregion


		#region Xml
		public void WriteXmlSubtree(XmlWriter writer)
		{
			writer.WriteStartElement(XmlStrings.MaskedIdsGen);
			writer.WriteAttributeString(XmlStrings.NameAttr, Name);
			writer.WriteStartElement(XmlStrings.ParamsNode);
			writer.WriteAttributeString("mask", Mask);
			writer.WriteEndElement();
			writer.WriteEndElement();
		}

		public void ReadXmlSubtree(XmlReader reader)
		{
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
				{
					if (reader.Name.Equals(XmlStrings.MaskedIdsGen, Helpers.IgnoreCase))
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
							if (reader.MoveToAttribute("mask"))
								Mask = reader.Value;
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
