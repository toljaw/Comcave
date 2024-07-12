namespace _07_oop_einkaufsliste;

public class Artikel
{
    private int _anzahl;

    public int Anzahl
    {
        get
        { return _anzahl; }
        set
        { _anzahl = value; }
    }

    private String _bezeichnung;
    public String Bezeichnung
    {
        get { return _bezeichnung;}
        set { _bezeichnung = value; }
    }

    public Artikel(int anzahl, String bezeichnung)
    {
        this.Anzahl = anzahl;
        this.Bezeichnung = bezeichnung;
    }
    
    public Artikel(String bezeichnung) : this(0, bezeichnung) {}

    public Artikel() : this(0, "Unbekannt") {}

    public override string ToString()
    {
        return $"{this.Anzahl}x {this.Bezeichnung}";
    }
    
}