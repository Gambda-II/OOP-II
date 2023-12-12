namespace P09_MockupProject;

public class Kunde
{

    public int ID { get; set; }
    public string Name { get; set; }
    public string Vorname { get; set; }
    public DateOnly RegistrierungsDatum { get; set; }
    public DateTime LetzterLogin { get; set; }

    public Kunde(int iD, string name, string vorname)
    {
        ID = iD;
        Name = name;
        Vorname = vorname;
        RegistrierungsDatum = DateOnly.FromDateTime(DateTime.Now);
        LetzterLogin = DateTime.Now;
    }
    
    public void Login()
    {
        LetzterLogin = DateTime.Now;
    }
}
