public class Activity
{
    public DateTime Date { get; set; }
    public int Minutes { get; set; }

    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Activity ({Minutes} min)";
    }
}
