
namespace P01_GL_OOP;
public class Echidna : Säugetier, IEierlegen
{
    public int StachelAnzahl { get; set; }
    public int Anzahl { get; set; }
    public TimeSpan Interval { get; set; }

    public void EierLegen()
    {
        Console.WriteLine("{0} legt {1} alle {2} Tage.", Name, Anzahl, Interval.TotalDays);
    }

    public override string ToString()
    {
        return base.ToString() + $"Stachelanzahl: {StachelAnzahl}\n";
    }
}
