using System;
using _05_oop_classes;

class Program
{
    static void Main()
    {
        // Erstellen einer neuen Instanz der Klasse Kunde
        Buch buch1 = new Buch("B00BPXHW5W", "Die unendliche Geschichte", "Michael Ende");
        
        // set Standort (da Property Setter verwendet, wird der Standort mit ... = "Paderborn gesetzt)
        buch1.Standort = "Paderborn";
        // wenn Getter/Setter Methode benutzt wäre, müsste man "buch1.Standort("Paderborn)" nutzen

        // Zugriff auf Methode "zeigeBuch"
        buch1.toString();
    }
}