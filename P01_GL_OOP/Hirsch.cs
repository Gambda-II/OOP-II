namespace P01_GL_OOP;
public class Hirsch : Säugetier
{
    public int GeweihAnzahl { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"Geweihanzahl: {GeweihAnzahl}\n";
    }
}
