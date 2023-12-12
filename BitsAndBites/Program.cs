namespace BitsAndBites;

internal class Program
{
    static void Main()
    {

    }
}

public abstract class Posten
{
    protected string name;
    protected double preis;

    public abstract double BerechnePreis();
}

public class Essen : Posten
{

    private bool extragross;

    public Essen(bool extragross, string name, double preis)
    {
        this.extragross = extragross;
        this.name = name;
        this.preis = preis;
    }

    public override double BerechnePreis()
    {
        return extragross ? preis * 1.20 : preis;
    }
}

public class Getraenk : Posten
{
    private bool alkoholisch;
    private bool happyhour;

    public Getraenk(bool alkoholisch, bool happyhour, string name, double preis)
    {
        this.alkoholisch = alkoholisch;
        this.happyhour = happyhour;
        this.name = name;
        this.preis = preis;
    }
    public override double BerechnePreis()
    {
        return happyhour && alkoholisch ? preis * 0.75 : preis;
    }
}

public class Ticket : Posten
{
    private TimeOnly startzeit;
    private int minuten;

    public Ticket(TimeOnly startzeit, int minuten, string name, double preis)
    {
        this.startzeit = startzeit;
        this.minuten = minuten;
        this.name = name;
        this.preis = preis;
    }

    public override double BerechnePreis()
    {
        return minuten * preis;
    }
}

public class Bestellung
{
    private bool bitandbitecard;
    private List<Posten> bestellung;

    public double BerechneBestellung()
    {
        double total = 0.0;

        foreach (Posten p in bestellung)
        {
            total += p.BerechnePreis();
        }

        return bitandbitecard ? total * 0.95 : total;
    }

    public void AddBestellung(Posten item)
    {
        bestellung.Add(item);
    }

}