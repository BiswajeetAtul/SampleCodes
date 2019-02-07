using System;

namespace Application
{
	public class Arithmetic
	{
		public int a,b;
		public Arithmetic ()
		{
			Console.WriteLine ("Enter values for a and b");
			a = Convert.ToInt32(Console.ReadLine ());
			b = Convert.ToInt32 (Console.ReadLine ());

		}
		public void arith(){
			

			Console.WriteLine ("CALCULATING");

			Console.WriteLine ("SUM {0}+{1}={2}", a, b, a + b);
			Console.WriteLine ("SUM {0}-{1}={2}", a, b, a - b);
			Console.WriteLine ("SUM {0}/{1}={2}", a, b, a / b);
			Console.WriteLine ("SUM {0}*{1}={2}", a, b, a * b);
			Console.WriteLine ("SUM {0}%{1}={2}", a, b, a % b);


		}

			

	}

	public class ArithmeticDemo{
		public static void Main(){
			Arithmetic ob= new Arithmetic();
			ob.arith ();
		}
	}
}

