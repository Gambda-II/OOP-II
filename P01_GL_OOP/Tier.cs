namespace P01_GL_OOP;

public abstract class Tier
{
    public long ID { get; set; }
    public string Name { get; set; }

    public DateOnly Geburtsdatum { get; set; }


    public override string ToString()
    {
        return $"ID: {ID}\nName: {Name}\nGeburtsdatum: {Geburtsdatum}\n";
    }
}

