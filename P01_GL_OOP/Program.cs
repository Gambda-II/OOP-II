namespace P01_GL_OOP;

internal class Program
{
    static void Main()
    {

        Hirsch hirsch = new Hirsch()
        {
            ID = 1,
            Name = "Peter",
            Geburtsdatum = new DateOnly(2010, 1, 1),
            GeweihAnzahl = 2,
            WurfGroesse = 1,

        };

        Echidna echidna = new Echidna()
        {
            ID = 2,
            Name = "Ecki",
            Geburtsdatum = new DateOnly(2017, 5, 6),
            StachelAnzahl = 69,
            Anzahl = 3,
            WurfGroesse = 4,
            Interval = new TimeSpan(20, 0, 0, 0),
        };

        Pinguin pinguin = new Pinguin()
        {
            ID = 3,
            Name = "Pengu",
            Geburtsdatum = new DateOnly(2023, 6, 23),
            FluegelSpannweite = 100,
            Schwimmgeschwindigkeit = 25,
            Anzahl = 4,
            Interval = new TimeSpan(1000, 100, 10, 1, 0),
        };

        Krähe krähe = new Krähe()
        {
            ID = 4,
            Name = "Cro Bro",
            Geburtsdatum = new DateOnly(2017, 9, 9),
            FluegelSpannweite = 30,
            Fluggeschwindigkeit = 17,
            Flughoehe = 99,
            Anzahl = 9,
            Interval = new TimeSpan(120, 0, 0, 0, 0, 0)
        };

        Hai hai = new Hai()
        {
            ID = 5,
            Name = "Bruce",
            Geburtsdatum = new DateOnly(2012, 12, 31),
            FlossenAnzahl = 2,
            Schwimmgeschwindigkeit = 100,
            KillCount = 420,

        };

        Seepferd seepferd = new Seepferd()
        {
            ID = 6,
            Name = "Seebastian",
            Geburtsdatum = new DateOnly(2001, 5, 11),
            FlossenAnzahl = 0,
            Schwimmgeschwindigkeit = 2,
            Homosexuell = null,

        };

        Console.WriteLine(hirsch);
        Console.WriteLine(echidna);
        Console.WriteLine(pinguin);
        Console.WriteLine(krähe);
        Console.WriteLine(hai);
        Console.WriteLine(seepferd);

        pinguin.Schwimmen();
        hai.Schwimmen();
        seepferd.Schwimmen();

        echidna.EierLegen();
        krähe.EierLegen();
        pinguin.EierLegen();

        krähe.Fliegen();

        Object[] obj = new Object[10];
        obj[0] = echidna;
    }
}