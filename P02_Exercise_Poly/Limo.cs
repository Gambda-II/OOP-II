namespace P02_Exercise_Poly;

internal class Limo : Fahrzeug
{
    public int LaengeInZentimeter { get; set; }
    override void ToString()
    {
        return base.ToString() + $"Länge (cm): \t {LaengeInZentimeter}\n";
    }
}
