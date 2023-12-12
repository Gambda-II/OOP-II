namespace P01_GL_OOP;
public abstract class Säugetier : Tier
{
    public int WurfGroesse { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"Wurfgröße: {WurfGroesse}\n";
    }
}