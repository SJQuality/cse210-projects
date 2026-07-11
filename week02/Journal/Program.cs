using System;
using System.Runtime.InteropServices;

/// <summary>
/// Enhancements: When loading a file (option 3), First the system checsk to see
///  if the List<Entry> _entries has info or not. If it does, the user is asked if
///  they want to ADD to the existing entries, if they want to clear the entries 
/// first, or go back to the menu.
/// In option 4 added a print statemtment that tells the user how many entries are
/// being saved.
/// </summary>

class Program
{
    static void Main(string[] args)
    {
        string option = "0";
        Journal journal = new Journal();


        while (option != "5")
        {
            Console.WriteLine("***Welcome to SJ's Journal!!***");
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            option = Console.ReadLine();

            //1. Write************************
            if (option == "1")
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string currentPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(currentPrompt);
                Entry entry = new Entry();
                entry._promptText = currentPrompt;
                entry._date = DateTime.Now.ToString("M/d/yyyy");
                entry._entryText = Console.ReadLine();

                journal.AddEntry(entry);
            }

            //2. Display
            if (option == "2")
            {
                journal.DisplayAll();
            }

            //3. Load
            if (option == "3")
            {
                if (journal._entries.Count > 0)
                {
                    Console.WriteLine("Looks like you have entries in your current view.");
                    Console.WriteLine("Please choose an option:");
                    Console.WriteLine("Option 1: Overwrite the current entries and load the file.");
                    Console.WriteLine("Option 2: Add the file to the current entries so you have all of them.");
                    Console.WriteLine("Option 3: Return to the main menu");
                    string loadOption = Console.ReadLine();

                    if (loadOption == "1")
                    {
                        journal._entries.Clear();
                        Console.WriteLine("What is the file name?");
                        string file = Console.ReadLine();
                        journal.LoadFromFile(file);
                    }

                    else if (loadOption == "2")
                    {
                        Console.WriteLine("What is the file name?");
                        string file = Console.ReadLine();
                        journal.LoadFromFile(file);
                    }

                    else if (loadOption == "3")
                    {

                    }
                }
                else
                {
                    Console.WriteLine("What is the file name?");
                    string file = Console.ReadLine();
                    journal.LoadFromFile(file);
                }
            }

            //4. Save
            if (option == "4")
            {
                Console.WriteLine("What file name do you want to save it as?");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
        }
    }
}