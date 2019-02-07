using System;

	public class TypeSize
	{
		public TypeSize ()
		{
		}
	public static void Main(string[] args){
		Console.WriteLine ("The Size of int IS :" + sizeof(int));
		Console.WriteLine ("The Size of long IS :" + sizeof(long));
		Console.WriteLine ("The Size of Float IS :" + sizeof(float));
		Console.WriteLine ("The Size of Double IS :" + sizeof(double));
		Console.WriteLine ("The Size of Decimal IS :" + sizeof(decimal));
		Console.WriteLine ("The Size of Bool IS :" + sizeof(bool));
		Console.WriteLine ("The Size of byte IS :" + sizeof(byte));
		Console.WriteLine ("The Size of char IS :" + sizeof(char));
		Console.WriteLine ("The Size of ulonG IS :" + sizeof(ulong));

		Console.ReadKey ();

	}
}

