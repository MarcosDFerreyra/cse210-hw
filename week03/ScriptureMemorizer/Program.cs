using System;

class Program
{
    static void Main(string[] args)
    {
  
        Reference reference = new Reference("Juan", 3, 16);

        string text = "Porque de tal manera amó Dios al mundo";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("press ENTER to hide more words, or write quit to finish the program.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2); 
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\n¡Scripture completly hidden!");
    }
}
