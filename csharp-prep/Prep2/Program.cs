using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade_text = Console.ReadLine();
        int grade_number = int.Parse(grade_text);
        string letter = "";

        if (grade_number >= 90)
        {
            letter = "A";
        }
        else if (grade_number >= 80)
        {
            letter = "B";
        }
        else if (grade_number >= 70)
        {
            letter = "C";
        }
        else if (grade_number >= 60)
        {
            letter = "D";
        }
        else if (grade_number < 60)
        {
            letter = "F";
        }

        Console.Write($"Your final grade is: {letter}.\n");

        if (grade_number >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}