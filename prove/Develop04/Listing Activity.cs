using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;

public class ListingActivity : Activity
{
   private string [] _prompts = {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
   };

   public ListingActivity (string activityName, string description)
   {
    _activityName = activityName;
    _description = description;
   }

   public string GetRandomPromts ()
   {
    Random random = new Random();
    int index = random.Next(0,_prompts.Length);
    return _prompts[index];
   }

   public void RunActivity()
   {
    DisplayStartingMessage ();
    Console.WriteLine();
    Console.WriteLine("List as many responses as you can to the following prompt: ");
    Console.WriteLine(GetRandomPromts());
    Console.WriteLine();
    Console.Write("You may begin in: ");
    PauseWithCountDown();
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_duration);
    DateTime currentTime = startTime;
    int counter = 0;
    while (currentTime < futureTime)
    {
        counter += 1;
        Console.ReadLine();
        currentTime = DateTime.Now;
    }
    Console.WriteLine($"you have {counter} listed items: ");
    DisplayEndingMessage();
   }
}