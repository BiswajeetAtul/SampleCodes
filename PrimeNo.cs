using System;
using System.IO;

public class PrimeNo
{
    public static void Main() {
        Console.WriteLine("Enter the max limit");
        int a = Convert.ToInt32(Console.ReadLine());
        int j, i;
        FileStream F = new FileStream( "PRIME_LIST.txt" , FileMode.OpenOrCreate , FileAccess.ReadWrite );
        for (i = 0; i < a; i++) {
            for (j = 2; j < Math.Sqrt(i); j++) if (i % j == 0) break;
            if (j > i / j) F.WriteByte((byte)i);
            }
        }

     

}
