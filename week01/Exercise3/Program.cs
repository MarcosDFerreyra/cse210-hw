using System;

class Program
{
    static void Main(string[] args)
    {

        int userGuess = -1;

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);

        while (userGuess != magicNumber) 
        {
            Console.Write("what is your guess? ");
            string guess = Console.ReadLine();
            userGuess = int.Parse(guess);

            if (userGuess > magicNumber)
            {
                Console.WriteLine("lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("higher");
            }
            else
            {
                Console.WriteLine("you guess it!");
            }
        }
        
    }
}