public class Cycling : Activity
{
    public double Speed { get; set; }

    public override double GetDistance() => (Speed * Minutes) / 60;
    public override double GetSpeed() => Speed;
    public override double GetPace() => 60 / Speed;

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }
}
