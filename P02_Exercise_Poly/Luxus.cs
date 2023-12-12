namespace P02_Exercise_Poly;

internal class Luxus : Fahrzeug
{
    public int MaxGeschwindigkeit { get; set; }
    public int Zusatzversicherung { get; set; }
    public string Farbe { get; set; }
    override void ToString()
    {
        return base.ToString() + $"Höchstgeschw.: \t {MaxGeschwindigkeit}\n";
    }
}