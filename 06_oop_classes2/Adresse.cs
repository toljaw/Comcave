namespace _06_oop_classes2;

public class Adresse
{
    // Attribute
    private string _plz;
    private string _ort;
    private string _straße;
    
    
    // Getter/Setter Properties
    public string PLZ
    {
        get { return _plz; }
        set { _plz = value; }
    }
    
    public string Ort
    {
        get { return _ort; }
        set { _ort = value; }
    }
    
    public string Straße
    {
        get { return _straße; }
        set { _straße = value; }
    }
}