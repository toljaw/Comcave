namespace _07_oop_einkaufsliste;

class Program
{
    static void Main(string[] args)
    {
        List<Artikel> artikelListe = new List<Artikel>();
        
        artikelListe.Add(new Artikel(5, "Tomaten"));
        artikelListe.Add(new Artikel(1, "Brot"));
        artikelListe.Add(new Artikel(2, "Nutella"));

        foreach (Artikel artikel in artikelListe)
        {
            Console.WriteLine(artikel);
        }
        {
            
        }
    }
}