using System;

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        string _userSelection = "0";
        while (_userSelection != "5")
        {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        _userSelection = Console.ReadLine();
        if (_userSelection == "1")
        {
            //I show creativity and exceeds core requirements reading a file with prompts and return random one.
        Console.WriteLine("\nyou chosed 1. Write\n");
        Journal uno = new Journal ();
        uno.AddEntry();
        }
        else if (_userSelection == "2")
        {
        Console.WriteLine("you chosed 2. Display");
        Journal dos = new Journal();
        dos.DisplayAll();
        }
        else if (_userSelection == "3")
        {
        Console.WriteLine("you chosed 3. Load");
        }
        else if (_userSelection == "4")
        {
        Console.WriteLine("you chosed 4. Save");
        }
        else if (_userSelection == "5")
        {
        Console.WriteLine("you chosed 5. Quit, good bye");
        }
        }
=======
        Console.WriteLine("Hello Develop02 World! knicks");
>>>>>>> 2e3985917dc8dade5c7011c386fc94a31f79f82f
    }
}