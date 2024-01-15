using System;

class Program
{
    static void Main(string[] args)
    {
     Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess_number = -1;

        while (guess_number != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess_number = int.Parse(Console.ReadLine());

            if (magicNumber > guess_number)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess_number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }        
    }
}