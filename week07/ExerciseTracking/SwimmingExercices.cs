public class SwimmingExercices : Exercices
{
    private double _swimmingLap ;

    public SwimmingExercices(double minutes, double swimmingLap) : base(minutes)
    {
        _swimmingLap = swimmingLap;
    }
    public override double GetDistance()
    {
        return _swimmingLap * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _minutes * 60.0;
    }
    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{FechaActual.ToString("dd MMM yyyy")} Swimming({_minutes} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km");
    }
}