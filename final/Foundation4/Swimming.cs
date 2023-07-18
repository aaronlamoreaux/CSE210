public class Swimming : Activity
{
    private double _numOfLaps = 0;
    public Swimming(double duration, double distance, double speed, double pace, double numOfLaps) : base(duration, distance, speed, pace)
    {
        _numOfLaps = numOfLaps;
        SetActivityType("Swimming");
    }

    public double GetNumOfLaps()
    {
        return _numOfLaps;
    }

    public override double Distance()
    {
        if (GetDistance() == 0)
        {
            return GetNumOfLaps() * 50 / 1000;
        }
        else
        {
            return GetDistance();
        }
    }

    public override double Pace()
    {
        if (GetPace() == 0 && GetSpeed() == 0)
        {
            return GetDuration() / Distance();
        }
        if (GetPace() == 0 && GetSpeed() != 0)
        {
            return 60 / Speed();
        }
        else
        {
            return GetPace();
        }
    }

    public override double Speed()
    {
        if (GetSpeed() == 0 && GetPace() == 0)
        {
            return (Distance() / GetDuration()) * 60;
        }
        if (GetSpeed() == 0 && GetPace() != 0)
        {
            return 60 / Pace();
        }
        else
        {
            return GetSpeed();
        }
    }

    public override string Summary()
    {
        double distance = Math.Round(Distance(), 1);
        double speed = Math.Round(Speed(), 1);
        double pace = Math.Round(Pace(), 1);
        return $"{GetDate().ToString("MM/dd/yyyy")} {GetActivityType()} ({GetDuration()})- Distance {distance} km, Speed {speed} kph, Pace {pace} min per km";
    }
}