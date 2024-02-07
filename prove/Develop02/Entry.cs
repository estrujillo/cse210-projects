using System;
using System.IO;
using System.Collections.Generic;

public class Entry
{
    
    public string _date {get; set;}
    public string _promptText {get; set;}
    public string _entryText {get; set;}
    public Entry()
    {
    }
    
    public void Display()
    {
        Console.WriteLine($"\n{_date}\n {_promptText}\n {_entryText}\n");
    }
}