namespace _06_oop_classes2;

public class Bestellungen
{
    // Attribute
    private string _bestellnummer;
    private string _status;
    private string _rechnungsadresse;
    private string _lieferadresse;
    
    
    // Getter/Setter Properties
    public string Bestellnummer
    {
        get { return _bestellnummer; }
        set { _bestellnummer = value; }
    }
    
    public string Status
    {
        get { return _status; }
        set { _status = value; }
    }
    
    public string Rechnungsadresse
    {
        get { return _rechnungsadresse; }
        set { _rechnungsadresse = value; }
    }
    
    public string Lieferadresse
    {
        get { return _lieferadresse; }
        set { _lieferadresse = value; }
    }
}