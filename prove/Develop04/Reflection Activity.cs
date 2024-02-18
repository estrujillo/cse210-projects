using System;
using System.Reflection;

public class ReflectionActivity : Activity
{
    private string [] _prompts = {
       "Think of a time when you stood up for someone else.",
       "Think of a time when you did something really difficult.",
       "Think of a time when you helped someone in need.",
       "Think of a time when you did something truly selfless."
    };

    private string [] _questions = {
       "Why was this experience meaningful to you?",
       "Have you ever done anything like this before?",
       "How did you get started?",
       "How did you feel when it was complete?",
       "What made this time different than other times when you were not as successful?",
       "What is your favorite thing about this experience?",
       "What could you learn from this experience that applies to other situations?",
       "What did you learn about yourself through this experience?",
       "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public string GetRandomPromts()
    {
        Random random = new Random();
        int index = random.Next(0,_prompts.Length);
        return _prompts[index];
    }

     public string GetRandomQuestions()
    {
        Random random = new Random();
        int index = random.Next(0,_questions.Length);
        return _questions[index];
    }

     public void DisplayPrompts()
    {
       Console.WriteLine(GetRandomPromts());
    }

    public void DisplayQuestions()
    {
       Console.WriteLine(GetRandomQuestions());
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        DisplayPrompts();
        Console.WriteLine();
        Console.WriteLine("When you have something in your mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now think of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in: ");
        PauseWithCountDown();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = startTime;
        while (currentTime < futureTime)
        {
            DisplayQuestions();
            PauseWithSpinner();
            currentTime = DateTime.Now;
        }
        Console.WriteLine();
        DisplayEndingMessage();
    }
}