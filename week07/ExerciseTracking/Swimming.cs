public class Swimming : Activity
{
    public int Laps { get; set; }

    public override double GetDistance() => Math.Round((Laps * 50) / 1000.0 * 0.62, 2);
    public override double GetSpeed() => Math.Round((GetDistance() / Minutes) * 60, 2);
    public override double GetPace() => Math.Round(Minutes / GetDistance(), 2);

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }
}
