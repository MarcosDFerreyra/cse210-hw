using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> listNumbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int numbers;
        int sum = 0;
        Double averageNumber = 0;
        do
        {
            Console.Write("Enter number: ");
            string userNumbers = Console.ReadLine();
            numbers = int.Parse(userNumbers);
            if (numbers != 0)
            {
                listNumbers.Add(numbers);
                sum += numbers;
                averageNumber = listNumbers.Average();
            }
        } while (numbers != 0);

        int largeNumber = 0;
        foreach (int number in listNumbers)
        {
            if (number > largeNumber)
            {
                largeNumber = number;
            }
        }
        Console.WriteLine($"the sum is: {sum}");
        Console.WriteLine($"the avarage number is: {averageNumber}");
        Console.WriteLine($"the largest number is: {largeNumber}");
    }
}