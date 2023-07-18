public class Running : Activity
{
    public Running(double duration, double distance, double speed, double pace) : base(duration, distance, speed, pace)
    {
        SetActivityType("Running");
    }
    public override double Distance()
    {
        return GetDistance();
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
}