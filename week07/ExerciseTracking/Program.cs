using System;

class Program
{
    static void Main(string[] args)
    {
        RunningExercices runningExercices = new RunningExercices(30, 4.8);
        runningExercices.GetSummary();
        Console.WriteLine();
        CyclingExercices cyclingExercices = new CyclingExercices(30, 10);
        cyclingExercices.GetSummary();
        Console.WriteLine();
        SwimmingExercices swimmingExercices = new SwimmingExercices(30, 10);
        swimmingExercices.GetSummary();
    }
}