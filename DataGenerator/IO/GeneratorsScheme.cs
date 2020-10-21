using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.IO
{
	public static class GeneratorsScheme
	{
		#region event: FileNotExists
		public static event EventHandler FileNotExists;
		#endregion


		#region public: Load, Save
		public static BaseGen[] Load(string filename)
		{
			if (!File.Exists(filename))
			{
				FileNotExists?.Invoke(null, EventArgs.Empty);
				return new BaseGen[0];
			}

			var stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
			var list = new BaseGen[0];
			try
			{
				var sets = new XmlReaderSettings() { IgnoreWhitespace = true };
				using (XmlReader reader = XmlReader.Create(stream, sets))
				{
					bool isRightFile = false;
					while (reader.Read())
					{
						if (reader.NodeType == XmlNodeType.Element)
							if (reader.Name.Equals(XmlStrings.RootTag))
								isRightFile = true;
							else if (isRightFile && reader.Name.Equals(XmlStrings.GeneratorsTag))
								list = ReadGenerators(reader);
					}
				}
			}
			finally
			{
				stream.Close();
				stream.Dispose();
			}

			return list;
		}

		public static void Save(string filename, BaseGen[] gens)
		{
			string workFile;
			FileStream stream = File.Create(workFile = Path.GetTempFileName());
			try
			{
				var settings = new XmlWriterSettings() { Indent = true, IndentChars = "\t" };
				using (XmlWriter writer = XmlWriter.Create(stream, settings))
				{
					// some comments and other info
					writer.WriteComment(DateTime.Now.ToString());
					writer.WriteStartElement(XmlStrings.RootTag);
					writer.WriteStartElement(XmlStrings.GeneratorsTag);

					// Generators themselfes
					foreach (var gen in gens)
					{
						if (gen is IXmlable g)
							g.WriteXmlSubtree(writer);
					}
					
					writer.WriteFullEndElement();   // GeneratorsTag
					writer.WriteFullEndElement();   // RootTag
				}
			}
			finally
			{
				stream.Close();
				stream.Dispose();
			}
			File.Move(workFile, filename);
		}
		#endregion


		#region private: ReadGenerators, ReadGen
		static BaseGen[] ReadGenerators(XmlReader reader) 
		{
			var list = new List<BaseGen>();
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
				{
					if (reader.Name.Equals(XmlStrings.ConstantGen))
						list.Add(ReadGen(new ConstantStringsGen(""), reader));
					else if (reader.Name.Equals(XmlStrings.DatesGen))
						list.Add(ReadGen(new DatesGen(DateTime.Now, DateTime.Now), reader));
					else if (reader.Name.Equals(XmlStrings.DoublesGen))
						list.Add(ReadGen(new DoublesGen(0, 1, 2), reader));
					else if (reader.Name.Equals(XmlStrings.IdsGen))
						list.Add(ReadGen(new IdsGen(1), reader));
					else if (reader.Name.Equals(XmlStrings.IntegersGen))
						list.Add(ReadGen(new IntegersGen(1,2), reader));
					else if (reader.Name.Equals(XmlStrings.MaskedIdsGen))
						list.Add(ReadGen(new MaskedIdsGen("abc"), reader));
					else if (reader.Name.Equals(XmlStrings.NothingGen))
						list.Add(ReadGen(new NothingGen(), reader));
					else if (reader.Name.Equals(XmlStrings.RndSymbolsGen))
						list.Add(ReadGen(new RndSymbolsGen(new[] { "abc" }), reader));
					else if (reader.Name.Equals(XmlStrings.StringsGen))
						list.Add(ReadGen(new StringsGen(new[] { "abc" }), reader));
				}
			}
			return list.ToArray();
		}

		static BaseGen ReadGen(BaseGen gen, XmlReader reader)
		{
			XmlReader sub = reader.ReadSubtree();
			if (gen is IXmlable g)
				g.ReadXmlSubtree(sub);
			sub.Close();
			return gen;
		}
		#endregion
	}
}
