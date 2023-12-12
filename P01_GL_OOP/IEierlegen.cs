namespace P01_GL_OOP;
internal interface IEierlegen
{
    int Anzahl { get; set; }

    TimeSpan Interval { get; set; }
    void EierLegen();
}
