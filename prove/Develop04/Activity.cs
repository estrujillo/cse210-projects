using System;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.WriteLine(_activityName);
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready....");
        PauseWithSpinner();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        PauseWithSpinner();
        Console.WriteLine();
        Console.Write($"You have completed another {_duration} seconds of {_activityName}");
        PauseWithSpinner();
    }

    public void PauseWithSpinner()
    {
        List<string> animationstrings = new List<string>();
        animationstrings.Add("|");
        animationstrings.Add("/");
        animationstrings.Add("-");
        animationstrings.Add("\\");
        animationstrings.Add("|");
        animationstrings.Add("/");
        animationstrings.Add("-");
        animationstrings.Add("\\");

        foreach (string str in animationstrings)
        {
            Console.Write(str);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void PauseWithCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}