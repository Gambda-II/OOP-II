
namespace P01_GL_OOP;
public abstract class Vogel : Tier, IEierlegen
{

    public int FluegelSpannweite { get; set; }
    public int Anzahl { get; set; }
    public TimeSpan Interval { get; set; }

    public void EierLegen() 
    {
        Console.WriteLine("{0} legt {1} alle {2} Tage.",Name, Anzahl,Interval.TotalDays);
    }

    public override string ToString()
    {
        return base.ToString() + $"Flügelspannweite: {FluegelSpannweite}\n";
    }
}