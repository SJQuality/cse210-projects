using System;

class Program
{
    static void Main(string[] args)
    {

        string again = "yes";
        Console.WriteLine("Welcome to SJ's Random Number Game!");

        while (again == "yes")
        {

            Random randomGenerator = new Random();

            int magic = randomGenerator.Next(1, 101);
            int guess = -1;
            int count = 0;


            while (guess != magic)
            {

                Console.WriteLine("What is your guess? ");
                count++;
                string input = Console.ReadLine();
                guess = int.Parse(input);
                if (guess > magic)
                {
                    Console.WriteLine("Lower");

                }

                else if (guess < magic)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {count} tries!");
                    Console.WriteLine("Would you like to try again? ('yes' or 'no'): ");
                    again = Console.ReadLine();
                }

            }

        }

    }
}