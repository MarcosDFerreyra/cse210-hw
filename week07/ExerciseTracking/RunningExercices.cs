public class RunningExercices : Exercices
{
    private double _distance;

    public RunningExercices(double minutes, double distance) : base(minutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _minutes * 60.0;
    }
    public override double GetPace()
    {
        return _minutes / _distance;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{FechaActual.ToString("dd MMM yyyy")} ({_minutes} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km");
    }
}