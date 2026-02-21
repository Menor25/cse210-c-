public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public int GetMinutes()
    {
        return _minutes;
    }

    public string GetSummary()
    {
        double distance = Math.Round(GetDistance(), 1);
        double speed = Math.Round(GetSpeed(), 1);
        double pace = Math.Round(GetPace(), 1);
        
        return $"{_date} {this.GetType().Name} ({_minutes} min) - Distance {distance} miles, Speed {speed} mph, Pace: {pace} min per mile";
    }
}