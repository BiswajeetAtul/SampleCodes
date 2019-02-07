using System;

namespace Application
{
	public class ARRAY_EXAMPLE
	{
		public void display(int[] a,int size){
			for(int i=0;i<size;i++){
				if(a[i]%2==0){
					Console.WriteLine ("/nTHE VALUE "+a[i]+" is even");
				}
				else{Console.WriteLine ("/nTHE VALUE "+a[i]+" is odd");}
			}
		}
		public static void Main(){
			ARRAY_EXAMPLE aEXE = new ARRAY_EXAMPLE ();
			//int n;
//1D ARRAY concept
			/*n = Convert.ToInt16 (Console.ReadLine ());
			Console.WriteLine ("Declaring the array");
			int[] arr= new int[n];
			for (int i = 0; i < n; i++) {
				arr [i] = Convert.ToInt16 (Console.ReadLine ());
			}
			int k = 0;
			foreach (int j in arr) {
				Console.WriteLine ("HTE current value: arr[ "+ k++ +"] : "+j);
			}
			Console.ReadKey ();
*/

			/*//2D ARRAY CONCEPT
			Console.WriteLine ("CREATING A 2d ARRAY");
			int[,] arr2d;
			int m;
			Console.WriteLine ("please enter teh dimensions of hte 2d array");
			n = Convert.ToInt16 (Console.ReadLine ());
			m = Convert.ToInt16 (Console.ReadLine ());
			arr2d = new int[n, m];
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < m; j++) {
					arr2d [i, j] = Convert.ToInt16 (Console.ReadLine ());
				}
			}
			/*for (int i = 0; i < n; i++) {
				for (int j = 0; j < m; j++) {
					Console.WriteLine ("the value at arr2d["+i+","+j+"]:\t"+arr2d[i,j]);
				}
			}*/
			/*int g=0,l=0;
			foreach (int k in arr2d) {
				Console.WriteLine ("the value at arr2d[]:\t"+k);
			}
			*/
		/*
			int a, b, c;
			Console.WriteLine ("STARTING THE 3D ARRAY");
			int[,,] arr3D;
			Console.WriteLine ("ENTER THE DIMENSIONS OF THE #D ARRAY");
			a = Convert.ToInt16 (Console.ReadLine ());
			b = Convert.ToInt16 (Console.ReadLine ());
			c = Convert.ToInt16 (Console.ReadLine ());
			arr3D = new int[a, b, c];
			for (int i = 0; i < a; i++) {
				for (int j = 0; j < b; j++) {
					for (int k = 0; k < c; k++) {
						arr3D [i, j, k] = Convert.ToInt16 (Console.ReadLine ());
					}
				}
			}
			for (int i = 0; i < a; i++) {
				for (int j = 0; j < b; j++) {
					for (int k = 0; k < c; k++) {
						Console.Write ("\tZarr3D[{0},{1},{2}]:\t{3}\t",i,j,k,arr3D[i,j,k]);
					}
					Console.Write ("\tX\t");
				}
				Console.WriteLine ("\tY\n");
			}
			//foreach (int t in arr3D) {
			//	Console.WriteLine ("\t"+t);
			//}
			*//*



			//Jagged ARRAy
			Console.WriteLine ("CREATING A JAGGED ARRAY>> ARRAY OF ARRAYS");
			int[][] JAggedArr;
			Console.WriteLine ("ENTER THE SIZE OF THE MAIN ARRAY");
			int a, b;
			a = Convert.ToInt16 (Console.ReadLine ());
			Console.WriteLine ("ENTER THE SIZE OF THE NOT MAIN ARRAY");
			b = Convert.ToInt16 (Console.ReadLine ());
			//c = Convert.ToInt16 (Console.ReadLine ());
			JAggedArr = new int[a][];
			for (int i = 0; i < JAggedArr.Length; i++) {
				JAggedArr[i]=new int[b];
			}
			for(int i=0;i<a;i++){
				for(int j=0;j<b;j++){
					JAggedArr[i][j]=Convert.ToInt16 (Console.ReadLine ());	
				}
			}//int t = 0;
			for(int i=0;i<JAggedArr.Length;i++){
				int[] temp=JAggedArr[i];
				foreach(int t in temp){
					Console.WriteLine ("--{0}--",t);
				}
			}*/ 
		/*
			Console.WriteLine ("SENDING ARRAys AS FuNCTIOn parAMETErs ");
			Console.WriteLine ("PLEase enter the array size and then the elements");
			int n = Convert.ToInt16 (Console.ReadLine ());
			int[] aRR=new int[n];
			for(int i=0;i<n;i++){
				aRR [i] = Convert.ToInt16 (Console.ReadLine ()); 
			}
			a.display (aRR, aRR.Length);
		*/


		int[] aObj=new int[10];
		for(int i=0;i<10;i++){
			aObj[i] = Convert.ToInt16 (Console.ReadLine ());

		}
		foreach(int t in aObj){
			Console.Write("{0}\t",t);
		}
			aEXE.display (aObj,aObj.Length);
			Console.WriteLine ("FIXED?" + aObj.IsFixedSize);
			Console.WriteLine ("LENGTH?" + aObj.Length);
			Console.WriteLine ("READONLY?" + aObj.IsReadOnly);Console.WriteLine ("LONGLENGTH?" + aObj.LongLength);Console.WriteLine ("RANK?" + aObj.Rank);
			Console.WriteLine ("PROPERTIES END");
			Console.WriteLine ("CLEARING");Array.Clear (aObj,8,2);foreach(int t in aObj){
				Console.Write("{0}\t",t);
			}
			Console.WriteLine ("GETLENGTH?" + aObj.GetLength ());Console.WriteLine ("INDEX OF 5?" + Array.IndexOf (aObj,5));Console.WriteLine ("REVERSED?" + Array.Reverse (aObj));foreach(int t in aObj){
				Console.Write("{0}\t",t);
			}Console.WriteLine ("SORTED?" + Array.Sort (aObj));foreach(int t in aObj){
				Console.Write("{0}\t",t);
			}










		}



	}
}