using System;
using System.Net.Quic;
using System.Runtime;


//Lots of improvements!
//1. Added methods public static Scripture LoadFromFile() and private static int GetRandomVerse(int lineCount)
//to Scriptures class to get random scriptures from files
//2. Added functionality to only hide words that have not been hidden yet
//3. Added method public string GetReferenceText() to Scriptures class to solve a problem
//with getting the Reference 
class Program
{
    static void Main(string[] args)
    {

        Scripture scripture = Scripture.LoadFromFile();

        Console.WriteLine("");
        Console.WriteLine("****Weclome to SJ Scripture memorizing tool!!****");
        Console.WriteLine("");


        string quit = "";
        while (quit != "quit")
        {

            Console.WriteLine(scripture.GetReferenceText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press 'Enter' to hide more words or type 'quit' to quiit");

            quit = Console.ReadLine();

            if (scripture.IsCompletelyHidden() == true)
            {
                quit = "quit";
            }
            scripture.HideRandomWords(3);
            Console.Clear();

        }

    }
}