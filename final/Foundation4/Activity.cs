public abstract class Activity
{
    DateTime _date = DateTime.Now;

    public double _duration = 0;

    public string _type = "";

    public double _distance = 0;
    public double _speed = 0;
    public double _pace = 0;

    public Activity(double duration, double distance, double speed, double pace)
    {
        _duration = duration;
        _distance = distance;
        _speed = speed;
        _pace = pace;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public double GetDuration()
    {
        return _duration;
    }

    public string GetActivityType()
    {
        return _type;
    }

    public double GetDistance()
    {
        return _distance;
    }

    public double GetSpeed()
    {
        return _speed;
    }

    public double GetPace()
    {
        return _pace;
    }

    public void SetActivityType(string type)
    {
        _type = type;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public abstract string Summary();
}