using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zufallszahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schleife zum Wdh des Programms
            do
            {
                //Deklaration und Initialisierung eines Random-Objekts mittels Konstruktor-Aufruf (vgl. Modul 04)
                Random generator = new Random();
                int benutzerZahl;
                //Aufruf der Würfel-Funktion des Random-Objekts (beachte: 1. Grenze inklusiv / 2. Grenze exklusiv)
                int zufallsZahl = generator.Next(1, 6);

                //Schleife für erneuten Versuch
                do
                {
                    //Abfrage des Tipps des Benutzers
                    Console.WriteLine("Bitte gib eine Zahl zwischen 1 und 5 ein: ");
                    benutzerZahl = int.Parse(Console.ReadLine());

                    //Vergleich Tipp <> Zufallszahl mittels If
                    if (benutzerZahl > zufallsZahl)
                    {
                        Console.WriteLine("Deine Zahl ist größer als die gewürfelte Zahl.");
                    }
                    else if (benutzerZahl < zufallsZahl)
                    {
                        Console.WriteLine("Deine Zahl ist kleiner als die gewürfelte Zahl.");
                    }
                    else
                    {
                        Console.WriteLine("Deine Zahl ist gleich der gewürfelten Zahl.");
                    }
                    //Bedingung für neuen Versuch
                } while (zufallsZahl != benutzerZahl);

                Console.WriteLine("Wiederholen? (Y/N)");
                //Bedingung für Wiederholung (Benutzer muss Taste 'Y' drücken) Übergabeparameter 'true' gibt an, das die gedrückte Taste nicht angezeigt wird
            } while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }
    }
}
