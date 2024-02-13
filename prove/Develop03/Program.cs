using System;

class Program
{
    static void Main(string[] args)
    {
        Reference refOne = new Reference ("John", 3, 5, 6);
        Scripture scriptOne = new Scripture (refOne, @"""Jesus answered Verily verily I say unto the Except a man be born of water and of the Spirit he cannot enter into the kingdom of God That which is born of the flesh is flesh and that which is born of the Spirit is spirit""");

        Reference refTwo = new Reference ("Acts", 2, 36, 37);
        Scripture scriptTwo = new Scripture (refTwo, @"""Therefore let all the house of Israel know assuredly, that God hath made that same Jesus, whom ye have crucified, both Lord and Christ. Now when they heard this, they were pricked in their heart and said unto Peter and to the rest of the apostles Men and brethren what shall we do?""");

        Reference refThree = new Reference ("1 Corinthians", 6, 19, 20);
        Scripture scriptThree = new Scripture (refThree, @"""What? know ye not that your body is the temple of the Holy Ghost which is in you, which ye have of God, and ye are not your own? For ye are bought with a price: therefore glorify God in your body and in your spirit which are God’s""");

        List<Scripture> _scriptures = new List<Scripture>();
        _scriptures.Add(scriptOne);
        _scriptures.Add(scriptTwo);
        _scriptures.Add(scriptThree);


        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        Scripture _scripture = _scriptures[index];
        _scripture.PrintText();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        string myMessage = "";
        
        while (myMessage != "quit" & _scripture.IscompletelyHidden()==false)
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
    //I exceeded the requirements developing a section of three scriptures to choose one of these randomly
}