using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction1.GetFraction());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction2.GetFraction());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(fraction3.GetFraction());

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetDecimalValue());
        Console.WriteLine(fraction4.GetFraction());
    }
}