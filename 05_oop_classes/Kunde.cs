namespace _05_oop_classes;

public class Kunde
{
    // Automatische Eigenschaften für Vorname und Nachname
    public string Vorname { get; set; }
    public string Nachname { get; set; }

    // Konstruktor, um Vorname und Nachname zu initialisieren
    public Kunde(string vorname, string nachname)
    {
        Vorname = vorname;
        Nachname = nachname;
    }
}