using System;
using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
        
    }

    public void DisplayAll()
    {
    
        Console.WriteLine("\nEntries: \n");
        foreach (var entries in _entries)
        {
            Console.WriteLine(entries._date);
            Console.WriteLine(entries._promptText);
            Console.WriteLine(entries._entryText);
        }
    }

    public void AddEntry()
    {
        Entry tres = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        tres._date = theCurrentTime.ToShortDateString();
        tres._promptText = PromptGenerator.GetRandomPrompt();
        Console.WriteLine($"\n{tres._promptText}\n");
        tres._entryText = Console.ReadLine();
       
       _entries.Add(tres);

        Console.WriteLine($"\nyour complete entry is the following:\n {tres._date}\n {tres._promptText}\n {tres._entryText}\n");
        /*foreach (var entries in _entries)
        {
            Console.WriteLine(entries);
        }*/
    }
    public void SaveToFile()
    {
        /*string fileName = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the f");
            // You can use the $ and include variables just like with
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }*/
    }
    public void LoadToFile()
    {
        /*string filename = "myjournal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
        string firstName = parts[0];
        string lastName = parts[1];*/
    }
}