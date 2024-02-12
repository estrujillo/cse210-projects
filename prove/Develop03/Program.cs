using System;

class Program
{
    static void Main(string[] args)
    {
        Reference refOne = new Reference ("John", 3, 5, 6);
        Scripture scriptOne = new Scripture (refOne, @"""Jesus answered, Verily, verily, I say unto thee, 
        Except a man be aborn of water and of the Spirit, he cannot denter into the kingdom of 
        God. That which is born of the flesh is flesh; and that which is born of the Spirit is
        spirit.""");

        List<Scripture> _scriptures = new List<Scripture>();
        _scriptures.Add(scriptOne);

        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        Scripture _scripture = _scriptures[index];
        _scripture.PrintText();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string myMessage = "";
        
        while (myMessage != "quit" & _scripture.IscompletelyHidden()==false);
        {
            myMessage = Console.ReadLine().Trim().ToLower();
            _scripture.Hiddewords();
            Console.Clear();
            _scripture.PrintText();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        }        
    }
    /*I exceeded the requirements by making my program........ "Im thinking"...........
    */
}