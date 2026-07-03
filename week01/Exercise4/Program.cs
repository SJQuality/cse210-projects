using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to SJ's fun with numbers!");

        int input = -1;
        List<int> numbers = new List<int>();


        while (input != 0)
        {

            Console.WriteLine("Please provide a number: (type '0' to stop)");
            string inputString = Console.ReadLine();
            input = int.Parse(inputString);

            if (input != 0)
            {
                numbers.Add(input);

            }

        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float ave = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {ave}");

        int largest = -1;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");

        int lowest = largest;
        foreach (int number in numbers)
        {
            if (number > 0 && number < lowest)
            {
                lowest = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {lowest}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}