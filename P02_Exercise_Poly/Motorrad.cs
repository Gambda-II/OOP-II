namespace P02_Exercise_Poly;

internal class Motorrad : Fahrzeug
{
    public bool? HelmInklusive {get; set; }
    override void ToString()
    {
        return base.ToString() + $"inkl. Helm:\t {HelmInklusive}\n";
    }
}