namespace _05_oop_classes;

public class Buch
{
    // Attribute
    private string _isbn;
    private string _titel;
    private string _autor;
    private string _standort;

    
    // Getter/Setter Properties
    /*public string ISBN
    {
        get { return _isbn; }
        set { _isbn = value; }
    }
    
    public string Titel
    {
        get { return _titel; }
        set { _titel = value; }
    }
    
    public string Autor
    {
        get { return _autor; }
        set { _autor = value; }
    }*/
    
    public string Standort
    {
        get { return _standort; }
        set { _standort = value; }
    }
    
    
    // Konstruktor
    public Buch(string isbn, string titel, string autor)
    {
        // hier kämmen die Set methoden
        _isbn  = isbn;
        _titel = titel;
        _autor = autor;
    }

    
    // Methoden
    public void toString()
    {
        Console.WriteLine($"ISBN: {_isbn}");
        Console.WriteLine($"Titel: {_titel}");
        Console.WriteLine($"Autor: {_autor}");
        Console.WriteLine($"Standort: {_standort}");
    }
}