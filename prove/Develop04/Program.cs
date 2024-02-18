using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        while (userInput != "5")
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine();
            Console.WriteLine("1) Breathing Activity");
            Console.WriteLine("2) Reflection Activity");
            Console.WriteLine("3) Listing Activity");
            Console.WriteLine("5) Quit");
            Console.WriteLine();
            Console.WriteLine("Which activity want to execute? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
        {
            BreathingActivity firstexercise = new BreathingActivity("The Breathing activity", "Description: This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            firstexercise.RunActivity();
        }
        else if (userInput == "2")
        {
            ReflectionActivity secondexercise = new ReflectionActivity("The Reflection activity", "Description: This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            secondexercise.RunActivity();
        }
        else if (userInput == "3")
        {
            ListingActivity thirdexercise = new ListingActivity("The Listing activity", "Description: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            thirdexercise.RunActivity();
        }
        else if (userInput == "4")
        {
            Console.WriteLine("Sorry, this activity is empty, try with another activity");
            //exeeding requirements should be in this user option.
            //there is not an activity, but in case the user enter number 4, program will show a short message.
        }
        else if (userInput == "5")
        {

        }
        }
    }
}