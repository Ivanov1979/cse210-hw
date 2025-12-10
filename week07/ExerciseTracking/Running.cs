namespace ExerciseTracking;
public class Running : Activity
{
    // Distance is stored directly (in km)
    private double _distanceKm;

    public Running(string date, int minutes, double distanceKm)
        : base(date, minutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
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
        return $"{GetDate()} Running ({GetMinutes()} min) - " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace {GetPace():0.00} min per km";
    }
}
