using System;

namespace Application
{
	class ScratchCode
	{
		public static void Main(string[] args){

			Func<double,double> o = new  Func<double,double> (ScratchCode.aread);

			Square s = new Square ();

			System.Console.WriteLine (s.Calculate(o));


		}

		public static double aread(double x){

			return x*x;
		}
	}
	public sealed class Square{

		private double d;
		public double Calculate(Func<double,double> op){
			return op (d);
		}
	}
}

