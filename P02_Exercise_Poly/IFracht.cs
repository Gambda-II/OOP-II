namespace P02_Exercise_Poly;

internal interface IFracht
{
     int Laenge { get; set; }
     int Breite { get; set; }
     int Hoehe { get; set; }

    void Frachtisieren();
}