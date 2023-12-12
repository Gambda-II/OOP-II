namespace P02_Exercise_Poly;

// TO ADD:
// CLASS: Traktor, Bus, fliegender Teppich / Besen, Panzer

internal abstract class Fahrzeug
{
    public string Kennzeichen { get; set; }
    public string Marke { get; set; }
    public int Baujahr { get; set; }
    public decimal PreisProTag { get; set; }
    public int Sitzplaetze { get; set; }

    override void ToString()
    {
        return 
            $"Kennzeichen:\t {Kennzeichen}\n" +
            $"Marke:\t {Marke}\n" +
            $"Baujahr:\t {Baujahr}\n" +
            $"Preis / Tag: \t {PreisProTag}\n" +
            $"Sitze: \t {Sitzplaetze}\n";
    }
}
