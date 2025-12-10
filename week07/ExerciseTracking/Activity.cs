namespace ExerciseTracking;
public abstract class Activity
{
    private string _date;
    private int _minutes;

    protected Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // These helpers are for the derived classes
    protected string GetDate()
    {
        return _date;
    }

    protected int GetMinutes()
    {
        return _minutes;
    }

    // Must be implemented in each derived class
    public abstract double GetDistance(); // km
    public abstract double GetSpeed();    // kph
    public abstract double GetPace();     // min per km

    public virtual string GetSummary()
    {
        return $"{_date} Activity ({_minutes} min)";
    }
}
