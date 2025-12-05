using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        string UserAnwser = "";
        while (UserAnwser != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Start Free Activity");
            Console.WriteLine("  5. Quit");
            Console.WriteLine("Select a choice from the Menu: ");
            UserAnwser = Console.ReadLine();

            if (UserAnwser == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                Console.Clear();

                breathingActivity.Run();
            }
            else if (UserAnwser == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                Console.Clear();
                reflectingActivity.Run();
            }
            else if (UserAnwser == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                Console.Clear();
                listingActivity.Run();
            }
            else if (UserAnwser == "4")
            {
                FreeActivity freeActivity = new FreeActivity();
                Console.Clear();
                freeActivity.Run();
            }
        }
    }
}