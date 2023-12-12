namespace P01_GL_OOP;
public class Pinguin : Vogel, ISchwimmen
{
    public int Schwimmgeschwindigkeit { get; set;  }

    public void Schwimmen()
    {
        Console.WriteLine("{0} schwimmt {1} Knoten, indem es mit den Füßen paddelt.",Name, Schwimmgeschwindigkeit);
    }

    public override string ToString()
    {
        return base.ToString() + $"Schwimmgeschwindigkeit: {Schwimmgeschwindigkeit}\n";
    }
}