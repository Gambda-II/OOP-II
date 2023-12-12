namespace P02_Exercise_Poly;

internal class Transporter : Fahrzeug, IFracht
{
    public int Laenge { get; set; }
    public int Breite { get; set; }
    public int Hoehe { get; set; }

    override void ToString()
    {
        return base.ToString() + $"Dimension:\n Länge: \t{Laenge}\nBreite: \t{Breite}\nHöhe: \t{Hoehe}\n";
    }

    void Frachtisieren()
    {
        Console.WriteLine("Brumm, brumm! Ich transportiere maximal {0} m³ Zeugs!\n", Lange * Breite * Hoehe / 1000);
    }
}