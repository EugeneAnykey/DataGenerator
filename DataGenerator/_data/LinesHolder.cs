﻿using System;
using System.IO;
using System.Reflection;

namespace EugeneAnykey.Project.DataGenerator
{
	public static class LinesHolder
	{
		// from files:
		public static readonly string[] EngWords;

		// hard coded:
		public static readonly string[] AlphabetLatin = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z".Split(',');

		public static readonly string[] EngParticles = "above,after,before,behind,in,in front,inside,off,on,over,out,outside,under".Split(',');

		public static readonly string[] Colors = new[] { "white", "black", "green", "blue", "red", "yellow", "violet", "cyan", "brown", "orange", "pink" };
		
		public static readonly string[] LongEngWords = new[] { "abstract", "boundary", "compositive", "deviation", "environment", "expensive", "experience", "features", "gestures", "historical", "however", "immediately", "immortal", "journey", "knowledge", "language", "mathematics", "moreover", "nocturnal", "opportunity", "parameters", "personality", "quantity", "recently", "synthetic", "thunder", "transportation", "unfortunately", "various", "weather", "xenophobia", "yesterday", "zucchini" };



		#region init
		static LinesHolder()
		{
			Assembly asm = Assembly.GetExecutingAssembly();

			var resources = asm.GetManifestResourceNames();

			EngWords = SplitByNewLine(GetTextStringFromEmbeded(asm, GetName(resources, "engWords.txt")));
			//RusWords = SplitByNewLine(GetTextStringFromEmbeded(asm, GetName(resources, "rusWords.txt")));
		}



		// gets text data in one string from embeded resource.
		static string GetTextStringFromEmbeded(Assembly assembly, string resourceName)
		{
			string res = string.Empty;

			if (string.IsNullOrEmpty(resourceName))
				return res;

			using (Stream resourceStream = assembly.GetManifestResourceStream(resourceName))
			{
				if (resourceStream == null)
					return res;

				using (StreamReader streamReader = new StreamReader(resourceStream))
				{
					res = streamReader.ReadToEnd();
				}
			}

			return res;
		}



		// gets first string that looks like the "lookFor" or empty string.
		static string GetName(string[] fromNames, string lookFor)
		{
			lookFor = lookFor.ToLower();

			foreach (var s in fromNames)
			{
				if (s.ToLower().Contains(lookFor))
					return s;
			}

			return string.Empty;
		}
		#endregion



		#region Split
		static string[] Split(char[] sep, string s)
		{
			return s.Split(sep, StringSplitOptions.RemoveEmptyEntries);
		}

		static string[] SplitByNewLine(string s)
		{
			char[] sep = new[] { '\r', '\n' };
			return Split(sep, s);
		}

		static string[] SplitBySpace(string s)
		{
			char[] sep = new[] { ' ' };
			return Split(sep, s);
		}
		#endregion
	}
}
