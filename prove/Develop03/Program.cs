using System;

class Program
{
    static void Main(string[] args)
    {
        Reference myref = new Reference ("John", 3, 5, 6);
        Scripture myscript = new Scripture (myref, @"""Jesus answered, Verily, verily, I say unto thee, 
        Except a man be aborn of water and of the Spirit, he cannot denter into the kingdom of 
        God. That which is born of the flesh is flesh; and that which is born of the Spirit is
        spirit.""");

        
    }
}