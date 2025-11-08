using System.Runtime.CompilerServices;
using System.IO;

public class Options
{
    Journal myJournal = new Journal();
    public void OptionsGenerator()
    
    {
        string userChose = "";
        while (userChose != "5")
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("what would you like to do? ");
            userChose = Console.ReadLine();

            if (userChose == "1")
            {
                myJournal.AddEntry();
            }
            else if (userChose == "2")
            {
                myJournal.DisplayAll();
            }
            else if (userChose == "3")
            {
                myJournal.loadFromFile();
            }
            else if (userChose == "4")
            {
                myJournal.SaveToFile();
            }
            
        }
    }
}