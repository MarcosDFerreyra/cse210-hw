public class CyclingExercices : Exercices
{
    private double _speed;

    public CyclingExercices(double minutes, double speed) : base(minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return _speed * (_minutes / 60.0);
    }
    public override Double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{FechaActual.ToString("dd MMM yyyy")} Cycling ({_minutes} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km");
    }
}