namespace P01_GL_OOP;
internal class Seepferd : Fisch
{
    // ? gibt an, dass ein Wert auch NULL annehmen kann

    public bool? Homosexuell { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"Homosexuell: {Homosexuell}\n";
    }
}
