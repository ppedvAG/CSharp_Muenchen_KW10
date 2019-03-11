using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpeichernUndLaden
{
    class Program
    {
        static void Main(string[] args)
        {
            //Frage nach Benutzerwunsch
            Console.WriteLine("Möchtest du Speichern oder Laden? (S=Speichern, L=Laden):");
            //Überprüfung des Tastendrucks auf Taste 'S'
            if (Console.ReadKey(true).Key == ConsoleKey.S)
            {
                //Aufruf der Speichern-Funktion
                StringSpeichern();
            }
            else
            {
                //Aufruf der Laden-Funktion
                LadeString();
            }

            Console.ReadKey();
        }

        //Methode zum Laden einer Textdatei
        private static void LadeString()
        {
            //Liste zum Zwischenspeichern der geladenen Strings
            List<string> geladeneStrings = new List<string>();

            //Deklarierung und Null-Initialisierung einer Streamreader-Variablen
            StreamReader reader = null;

            try
            {
                //Instanzierung des Streamreaders mit Übergabe eines Dateipfades
                reader = new StreamReader("gespeicherteDaten.txt");

                //Schleife, welche über die geöffnete Datei läuft
                while (!reader.EndOfStream)
                {
                    //Lesen einer Zeile aus der Datei
                    string aktuellerGeladenerString = reader.ReadLine();
                    //Hinzufügen der Zeile zu der Stringliste
                    geladeneStrings.Add(aktuellerGeladenerString);
                }

                //Erfolgsmeldung für User
                Console.WriteLine("\nLaden erfolgreich");
            }
            catch
            {
                //Misserfolgsmeldung für User bei Aufkommen einer Exception
                Console.WriteLine("\nLaden fehlgeschlagen");
            }
            finally
            {
                //Schließen der Datei innerhalb des Finally-Blocks, damit andere Programme auf die Datei zugreifen können (? = Nullprüfung des vorhergehenden Bezeichners)
                if (reader != null)
                    reader.Close();

                ////Alternative (? ersetzt Nullprüfung):
                //reader?.Close();
            }

            //Ausgabe der geladenen Stringliste
            foreach (var item in geladeneStrings)
            {
                Console.WriteLine(item);
            }
        }

        //Methode zum Speichern einer Textdatei (vgl. auch StringLaden())
        public static void StringSpeichern()
        {
            Console.WriteLine("Bitte gib einen Satz ein, den du abspeichern möchtest: ");

            string stringZumSpeichern = Console.ReadLine();

            List<string> stringListe = new List<string> { "Hallo", "Ciao", "Moin", "Servus" };

            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter("gespeicherteDaten.txt");

                //StreamWriter schreibt einen String in die Datei
                writer.WriteLine("Eingegebener String:");

                writer.WriteLine(stringZumSpeichern);

                foreach (var item in stringListe)
                {
                    writer.WriteLine(item);
                }

                Console.WriteLine("Speichern erfolgreich");
            }
            catch
            {
                Console.WriteLine("Speichern fehlgeschlagen");
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
