using System;

public class TypeConversion
{
    public static void Main()
    {
        int x;
        float zz;
        double y;
        decimal z;
        bool b;
        object o;
        string s;
        dynamic dyn;
        Console.WriteLine("Enter  the universal value:");
        o = Console.ReadLine();
        Console.WriteLine("CONVERTING INTO INT:");
        s = o.ToString();
        try {
            x = int.Parse(s);
            Console.WriteLine("Converted: x in Integer " + x);

            Console.WriteLine("CONVERTING INTO Boolean:");
            b = bool.Parse((x > 0) ? bool.TrueString : bool.FalseString);
            Console.WriteLine("CONVERTED: b in Boolean:" + b);
            
        }
        catch
        {
            Console.WriteLine("CANT CONVERT " + " '"+s+"'" + " INTO INTEGER");
        }
        try
        {
            Console.WriteLine("CONVERTING INTO FLOAT :");
            zz = float.Parse(s);
            Console.WriteLine("Converted: zz in Float " + zz);
        }
        catch
        {
            Console.WriteLine("CANT CONVERT " + "+s+" + " INTO Float");
        }
        try {
            Console.WriteLine("CONVERTING INTO DECiMAL:");
            z = decimal.Parse(s);
            Console.WriteLine("CONVERTED: b in Decimal:" + z);
        }
        catch
        {
            Console.WriteLine("CANT CONVERT " + "+s+" + " INTO Decimal");
        }
        try
        {
            Console.WriteLine("CONVERTING INTO DOuBlE:");
            y = double.Parse(s);
            Console.WriteLine("CONVERTED: y in Double:" + y);
        }
        catch
        {
            Console.WriteLine("CANT CONVERT " + "+s+" + " INTO Double");
        }

            
        
        
//        Console.WriteLine("CONVERTING INTO Dynamic:(GIVES EXCEPTIONS ?)");
        Console.WriteLine("Starting with Dynamic variable");
        dyn = Console.ReadLine();
        Console.WriteLine("DYN=" + dyn);



    }
}
