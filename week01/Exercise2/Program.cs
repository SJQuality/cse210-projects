using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to SJ's letter grade determiner!");

        Console.WriteLine("What is the grade persentage(%)?");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter = "";



        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        string sign = "";

        if (grade < 94 && grade > 59)
        {
            int remainder = grade % 10;

            if (remainder >= 7)
            {
                sign = "+";
            }

            else if (remainder <= 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (letter == "A" || letter == "B" || letter == "C" || letter == "D")
        {
            Console.WriteLine($"Congradulations! You passed the corse with an {letter}{sign}!");
        }

        else if (letter == "F")
        {
            Console.WriteLine($"Sorry! You have a grade of: {letter}. You have not passed the corse. Better luck next time!");
        }
    }
}