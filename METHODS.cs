using System;

namespace Application
{
	public class EmptyClass
	{
		public EmptyClass ()
		{
			
		}
		public void findMax(int a,int b){
			if (a > b) {
				Console.WriteLine (a+" IS MAX");
			} else {
				Console.WriteLine (b+" IS MAX");
			}
		}
		public void findMin(int a,int b){
			if(a<b){Console.WriteLine (a+"A IS MIN");}
			else{Console.WriteLine (b+"B IS MIN");}
		}
		public static void Main(){
			int a=0,b=0;
			EmptyClass e=new EmptyClass();
			//Console.WriteLine ("A,B,C are NULLS, "+a +b);
			Console.WriteLine ("ENTER SOME VALUES FOR A & B ");
			a = Convert.ToInt32 (Console.ReadLine ());
			b = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("VALUES FOR A & B "+a + b);
			e.findMax (a, b);
			e.findMin (a,b);
			//Console.WriteLine ("NOW C:"+c);
		}
	}
}

