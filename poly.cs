using System;

namespace Application
{
	public class poly
	{
		//double x;
		int n;
		double[] coeff;
		//double[] coeff2;
		//double[] coeff3;
		public poly(int i){
			n = 1;
			coeff[0]=0;
		}

		public poly ()
		{
			Console.WriteLine ("please enter the order of the polynomial");
			n = Convert.ToInt16 (Console.ReadLine ());
			double[] arr = new double[n+1];
			Console.WriteLine ("please enter the coefficients starting from A0 to An");
			for (int i = 0; i <= n; i++) {
				arr [i] = Convert.ToDouble (Console.ReadLine ());
			}
			coeff = arr;
		}
		public poly dpoly(poly p){
			this.n = p.n - 1;

			for (int i = 0; i <= this.n; i++)
				this.coeff [i] = p.coeff [i + 1] * (i + 1);

			return this;
			
		}
		public void display (){
			for (int i = 0; i <= n; i++) {
				Console.Write (coeff[i]+"x^"+i+"\t");
			}
		}
		public void sum(double start, double end, double increment){
			for (double j = start; j <= end; j += increment) {
				double temp=0;
				for (int i = 0; i <= n; i++) {
					temp += coeff [i] * Math.Pow (j, i);
					}
				Console.WriteLine ("\nfor x= " + j + " F(x)= " + temp);
			}

		}
	}

	public class polydemo{
		public static void Main()		{
			poly p=new poly();
			p.display();
			poly pdot=new poly(0);
			pdot.dpoly (p);
			//poly pdotdot=new poly(0);
			//pdotdot.dpoly (pdot);
			pdot.display ();
			//pdotdot.display ();
			//p.sum (1,3,0.1);
		}

	}
}

