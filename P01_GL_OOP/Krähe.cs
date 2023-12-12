namespace P01_GL_OOP;
internal class Krähe : Vogel, IFliegen
{
    public int Fluggeschwindigkeit { get; set; }
    public int Flughoehe { get; set; }

    public void Fliegen()
    {
        Console.WriteLine("{0} fliegt mit {1} km/h auf {2} m Höhe.", Name, Fluggeschwindigkeit, Flughoehe);
    }
}