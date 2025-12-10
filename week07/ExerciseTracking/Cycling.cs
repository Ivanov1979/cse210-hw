namespace ExerciseTracking;
public class Cycling : Activity
{
    // Here we store speed directly (kph)
    private double _speedKph;

    public Cycling(string date, int minutes, double speedKph)
        : base(date, minutes)
    {
        _speedKph = speedKph;
    }

    public override double GetSpeed()
    {
        return _speedKph;
    }

    public override double GetDistance()
    {
        // Distance (km) = speed (kph) * time (hours)
        // time (hours) = minutes / 60
        return _speedKph * (GetMinutes() / 60.0);
    }

    public override double GetPace()
    {
        // Pace (min per km) = 60 / speed
        return 60.0 / _speedKph;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetMinutes()} min) - " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace {GetPace():0.00} min per km";
    }
}
