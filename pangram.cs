using System;
using System.Collections.Generic;
using System.IO;

namespace Application
{
	public class EmptyClass
	{
		
		static void Main()
		{
				string s = Console.ReadLine ();
				//string[] values = s.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
				//Console.WriteLine (values [1]);
			//foreach (var item in values) {
			//	Console.WriteLine (item);
			//}

			HashSet<char> alpha = new HashSet<char> ();
			for (int i = 0; i < s.Length; i++) {
				alpha.Add (s[i]);
			}
			if (alpha.Contains (" ")) {
				alpha.Remove (" ");
			}
			if (alpha.Count == 26)
				Console.WriteLine ("pangram");
			else
				Console.WriteLine ("not pangram");

			foreach (var item in alpha) {
				Console.WriteLine (item);
			}
		}

	}
}

