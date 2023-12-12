namespace P02_Exercise_Poly;

internal class Pekawe : Fahrzeug
{
    public bool HatKindersitz { get; set; }
    override void ToString()
    {
        return base.ToString() + $"Kindersitz: \t {HatKindersitz}\n";
    }
}