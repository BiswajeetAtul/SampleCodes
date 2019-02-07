using System;

public class AcceptingData
{
	public static void Main()
    {
        int x;
        byte q;
        char w;
        long e;
        decimal r;
        double t;
        float y;
        Console.WriteLine("Enter Int:Byte:Char:Long:Decimal:Double:Float");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("x Integer:"+x);
        q = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("q Byte:" + q);
        w = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("w char:" + w);
        e = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("e Long:" + e);
        r = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("r Decimal:" + r);
        t = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("t double:" + t);
        y = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("y Float:" + y) ;


    }

}
