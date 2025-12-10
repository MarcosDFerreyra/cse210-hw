public abstract class Exercices
{
    protected double _minutes;
    protected DateTime fechaActual = DateTime.Today;

    public Exercices(double minutes)
    {
        _minutes = minutes;
    }

    public DateTime FechaActual => fechaActual;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual void GetSummary()
    {
        Console.WriteLine($"{FechaActual.ToString("dd MMM yyyy")}: ({_minutes}min): Distance {GetDistance()} km, Speed{GetSpeed()} kph, Pace {GetPace()} min per km");
    }

}

