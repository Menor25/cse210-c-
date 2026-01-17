using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();

        int gradeScore = int.Parse(gradePercentage);
        string letter;
        string sign = "";

        if(gradeScore >= 90)
        {
            letter = "A";
        }
        else if (gradeScore >= 80)
        {
            letter = "B";
        }
        else if (gradeScore >= 70)
        {
            letter = "C";
        }
        else if (gradeScore >= 60)
        {;
            letter = "D";   
        }
        else
        {
            letter = "F";
        }

        int lastDigit = gradeScore % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = ""; 
        }

        if (gradeScore >= 70)
        {
            Console.WriteLine($"Congratulations, you passed with a good grade. Your grade is: {letter}{sign}.");
        }
        else
        {
            Console.WriteLine($"You tried, but you need to do better next time. Your grade is: {letter}{sign}.");
        }
    }
}
