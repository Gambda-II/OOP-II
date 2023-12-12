namespace P01_GL_OOP;
internal class Hai : Fisch
{
    public int KillCount { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"Killcount: {KillCount}\n";
    }
}