namespace P01_GL_OOP;
public abstract class Fisch : Tier, ISchwimmen
{
    public int FlossenAnzahl { get; set; }
    public int Schwimmgeschwindigkeit { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"Flossenanzahl: {FlossenAnzahl}\nSchwimmgeschwindigkeit: {Schwimmgeschwindigkeit}\n";
    }

    public void Schwimmen()
    {
        Console.WriteLine("{0} schwimmt {1} Knoten, indem es mit den Flossen schwimmt.",Name,Schwimmgeschwindigkeit);
    }

}