using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what's your grade percentage? ");
        string grade = Console.ReadLine();
        int numberGrade = int.Parse(grade);
        string letter = "";
        if (numberGrade >= 90)
        {
            letter = "A";
        }
        else if (numberGrade >= 80)
        {
            letter = "B";
        }
        else if (numberGrade >= 70)
        {
            letter = "C";
        }
        else if (numberGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"your grade is {letter}");

        if (numberGrade >= 70)
        {
            Console.WriteLine("you pass the course, congratulations!!");
        }
        else
        {
            Console.WriteLine("sorry, you didn't pass, but you can try again");
        }
    }
}