namespace _06_oop_classes2;

public class Kunden
{
    // propfull - propertybuilder in visual studio???
    // Attribute
    private string _name;
    private string _kdnr;
    private string _adresse;
    
    
    // Getter/Setter Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    
    public string KdNr
    {
        get { return _kdnr; }
        set { _kdnr = value; }
    }
    
    public string Adresse
    {
        get { return _adresse; }
        set { _adresse = value; }
    }
    // verwende "prop" für:
    //public string vorname { get; set; }
}