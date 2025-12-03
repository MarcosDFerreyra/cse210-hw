using System;

class Program
{
    static void Main(string[] args)
    {
        Assing assigment = new Assing("juan gonzales", "Multiplication");
        Console.WriteLine(assigment.GetSummary());

        MathA mathA = new MathA("Roberto Rodriguez",  "Fractions", "7.3", "8-19");
        Console.WriteLine(mathA.GetSummary());
        Console.WriteLine(mathA.GetHomeworkList());

        textA textA = new textA("Mary Waters", "European History","The Causes of World War II by Mary Waters");
        Console.WriteLine(textA.GetSummary());
        Console.WriteLine(textA.GetWritingInfo());
    }
    
}