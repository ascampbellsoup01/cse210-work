public class Running : Activity
{
    public double Distance { get; set; }

    public override double GetDistance() => Distance;
    public override double GetSpeed() => (Distance / Minutes) * 60;
    public override double GetPace() => Minutes / Distance;

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }
}
