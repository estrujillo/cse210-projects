using System.IO;
using System.Collections.Generic;
public class Journal
{
    public List<string> _entries = new List<string>();


    public Journal()
    {
    }

    public void DisplayAll()
    {
        Journal cuatro = new Journal();
        Console.WriteLine("\nEntries: \n");
        foreach (var entries in cuatro._entries)
        {
            Console.WriteLine(entries);
        }
    }

    public void AddEntry()
    {
        DateTime theCurrentTime = DateTime.Now;
        Entry entryInstance = new Entry ();
        entryInstance._date = theCurrentTime.ToShortDateString();
        entryInstance._promptText = PromptGenerator.GetRandomPrompt();
        Console.WriteLine($"\n{entryInstance._promptText}\n");
        entryInstance._entryText = Console.ReadLine();

        Journal tres = new Journal();
        tres._entries.Add(entryInstance._date);
        tres._entries.Add(entryInstance._promptText);
        tres._entries.Add(entryInstance._entryText);

        Console.WriteLine($"\nyour complete entry is the following:\n {entryInstance._date}\n {entryInstance._promptText}\n {entryInstance._entryText}\n");
        foreach (var entries in tres._entries)
        {
            Console.WriteLine(entries);
        }
        return;
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