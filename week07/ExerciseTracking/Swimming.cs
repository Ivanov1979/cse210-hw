namespace ExerciseTracking;
public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Each lap = 50 meters
        // Distance (km) = laps * 50 / 1000
        return (_laps * 50) / 1000.0;
    }

    public override double GetSpeed()
    {
        // Speed (kph) = (distance / minutes) * 60
        return (GetDistance() / GetMinutes()) * 60.0;
    }

    public override double GetPace()
    {
        // Pace (min per km) = minutes / distance
        return GetMinutes() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetMinutes()} min) - " +
               $"Laps: {_laps}, " +
               $"Distance {GetDistance():0.00} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace {GetPace():0.00} min per km";
    }
}
