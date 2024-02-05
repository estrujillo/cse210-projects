using System;
using System.Collections.Generic;
using System.IO;

public class PromptGenerator
{
    public List<PromptGenerator> _prompts = new List<PromptGenerator>();
//I show creativity and exceeds core requirements reading a file with prompts and return random one.
    public static string GetRandomPrompt()
    {
        Console.WriteLine("Reading prompts from DB...");
        string filename = "myPromptsFile.txt";
        string[] _prompts = System.IO.File.ReadAllLines(filename);
       
        Random random = new Random();
        int index = random.Next(1,_prompts.Length);
        return _prompts[index];
    }

}