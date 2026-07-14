using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine($"{fraction1.GetFractionString()}");
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Console.WriteLine($"{fraction3.GetFractionString()}");

        Fraction setFrac = new Fraction();

        setFrac.SetTop(4);
        setFrac.SetBottom(10);
        Console.WriteLine($"The top is: {setFrac.GetTop()}");
        Console.WriteLine($"The bottom is: {setFrac.GetBottom()}");

        Console.WriteLine("*******Testing Begins*********");

        Fraction test0 = new Fraction();

        Console.WriteLine($"{test0.GetFractionString()}");
        Console.WriteLine($"{test0.GetDecimalValue():F2}");

        Fraction test1 = new Fraction(1);

        Console.WriteLine($"{test1.GetFractionString()}");
        Console.WriteLine($"{test1.GetDecimalValue():F2}");

        Fraction test5 = new Fraction(5);

        Console.WriteLine($"{test5.GetFractionString()}");
        Console.WriteLine($"{test5.GetDecimalValue():F2}");

        Fraction test34 = new Fraction(3, 4);

        Console.WriteLine($"{test34.GetFractionString()}");
        Console.WriteLine($"{test34.GetDecimalValue():F2}");

        Fraction test13 = new Fraction(1, 3);

        Console.WriteLine($"{test13.GetFractionString()}");
        Console.WriteLine($"{test13.GetDecimalValue():F2}");

    }
}