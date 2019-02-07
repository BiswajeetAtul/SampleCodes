using System;

public class EscapeSequence
{
	public static void Main()
	{
        Console.WriteLine("IN THIS PROGRAM WE ARE GOING TO DESCRIBE THE ESCAP SEQUENCES OF C#");
        Console.WriteLine(" THE CHARACTER SEQUENCES WHICH PRODUCE \\,\',\" ");
        Console.WriteLine("ARE \\ followed by that character");

        Console.WriteLine("to get a horizontal tab use \\ & t ");
        Console.WriteLine("Ex:-1\t this 2\t\t sentence 3\t\t\t has 1,2,3 tabs ");

        Console.WriteLine("to get a backspace  use \\ & b ");
        Console.WriteLine("Ex:-1 this  sentence 3 has 1,1,4 backspaces (ACTUALL)");
        Console.WriteLine("Ex:-1\b this \b sentence\b\b\b\b 3 has 1,1,4 backspaces ");

        //Console.WriteLine("to get form feed use \\ & f ");
        //Console.WriteLine("Ex:-1\f this 2\f sentence 3\f\f\f has 1,2,3 feeds ");

        Console.WriteLine("to get a new line use \\ & n ");
        Console.WriteLine("Ex:-1\n this 2\n\n sentence 3\n\n\n has 1,2,3 new lines ");

        Console.WriteLine("to get a carraige return tab use \\ & r ");
        Console.WriteLine("Ex:-this  sentence  has (*)a carraige return ");
        Console.WriteLine("Ex:-this \r sentence  has \ra carraige return ");

    }
}
