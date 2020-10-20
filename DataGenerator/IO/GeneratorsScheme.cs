using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using EugeneAnykey.Project.DataGenerator.Generators;

namespace EugeneAnykey.Project.DataGenerator.IO
{
	public static class GeneratorsScheme
	{
		#region event
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
			//throw new NotImplementedException();
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

		#region undone, bad
		delegate BaseGen ReadGenFromXml(XmlReader reader);
		struct GenXmlReader {
			readonly string Name;
			readonly ReadGenFromXml ReadFunc;

			public GenXmlReader(string name, ReadGenFromXml readFunc)
			{
				Name = name;
				ReadFunc = readFunc;
			}

			public BaseGen TryRead(string name, XmlReader reader)
			{
				if (Name.Equals(name))
					return ReadFunc(reader);
				else return null;
			}
		}

		/* bad
		static GenXmlReader[] readers = new GenXmlReader[] {
			new GenXmlReader("Constant", (new ConstantStringsGen("") as IXmlable).ReadXmlSubtree),
		};
		*/
		#endregion

		#region private
		static BaseGen[] ReadGenerators(XmlReader reader) 
		{
			var list = new List<BaseGen>();
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element)
				{
					if (reader.Name.Equals(XmlStrings.ConstantGen))
					{
						var constantGen = new ConstantStringsGen("");
						XmlReader sub = reader.ReadSubtree();
						constantGen.ReadXmlSubtree(sub);
						sub.Close();
						list.Add(constantGen);
					}
					else if (reader.Name.Equals(XmlStrings.DatesGen))
					{
						list.Add(ReadGen(new DatesGen(DateTime.Now, DateTime.Now), reader));
						//var datesGen = new DatesGen(DateTime.Now, DateTime.Now);
						//XmlReader sub = reader.ReadSubtree();
						//datesGen.ReadXmlSubtree(sub);
						//sub.Close();
						//list.Add(datesGen);
					}
					else if (reader.Name.Equals(XmlStrings.DoublesGen))
					{
						list.Add(ReadGen(new DoublesGen(0, 1, 2), reader));
						//var datesGen = new DatesGen(DateTime.Now, DateTime.Now);
						//XmlReader sub = reader.ReadSubtree();
						//datesGen.ReadXmlSubtree(sub);
						//sub.Close();
						//list.Add(datesGen);
					}
					else if (reader.Name.Equals(XmlStrings.IdsGen))
					{
						list.Add(ReadGen(new IdsGen(1), reader));
						//var idsGen = new IdsGen(1);
						//XmlReader sub = reader.ReadSubtree();
						//idsGen.ReadXmlSubtree(sub);
						//sub.Close();
						//list.Add(idsGen);
					}
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
			//var gen = new DatesGen(DateTime.Now, DateTime.Now);
			XmlReader sub = reader.ReadSubtree();
			if (gen is IXmlable g)
				g.ReadXmlSubtree(sub);
			sub.Close();
			return gen;
			//list.Add(datesGen);
		}
		#endregion
	}
}
