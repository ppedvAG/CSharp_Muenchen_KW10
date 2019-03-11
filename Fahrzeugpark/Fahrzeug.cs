using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Json ist eine Serialisierungs-Methode, welche über den NuGet-Marketspace installiert und dem Projekt hinzugefügt wurde
using Newtonsoft.Json;

namespace Fahrzeugpark
{
    //KLASSEN sind Vorlagen für OOP-Objekte. Hier wird das Aussehen, das Verhalten und der Startzustand für Objekte dieses Typs definiert.
    //Von einer als ABSTRACT gesetzten Klasse können keine Objekte instanziiert werden. Sie ist rein zur Vererbung gedacht.
    //Diese Klasse implementiert das Interface IClonable, welches die Klasse dazu befähigt, Kopien von ihren Objekten zu erzeugen. Dafür
    //erzwingt es die Implementierung der Methode Clone().
    public abstract class Fahrzeug : ICloneable
    {
        #region Statische Member
        //Als STATIC markierte Variablen und Methoden hängen an der Klasse selbst und nicht an instanziierten Objekten.
        public static int AnzahlFahrzeuge { get; set; } = 0;
        //Methode, welche die Anzahld der Fahrzeuge als String zurückgibt
        public static string ZeigeAnzahlFahrzeuge()
        {
            return "Es wurden " + AnzahlFahrzeuge + " Fahrzeuge produziert.";
        }

        //Statische Methode zum Abspeichern einer Liste von Fahrzeugen (vgl. auch SpeichereFz())
        public static void SpeichereFz(List<Fahrzeug> fzListe, string path = "gespeicherteFahrzeuge.fz")
        {
            StreamWriter writer = null;

            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.TypeNameHandling = TypeNameHandling.Objects;

            try
            {
                writer = new StreamWriter(path);

                //Schleife, welche über die übergebene Fahrzeugliste iteriert
                for (int i = 0; i < fzListe.Count; i++)
                {
                    //Ein Fahrzeug wird in einen String umgewandelt...
                    string fahrzeugAlsString = JsonConvert.SerializeObject(fzListe[i], setting);
                    //...und in die Datei geschrieben
                    writer.WriteLine(fahrzeugAlsString);
                }

                Console.WriteLine("Fahrzeuge wurden abgespeichert");
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

        //Methode zum Laden einer 'Fahrzeug'-Datei und Rückgabe der Fahrezuge an den Aufrufer (vgl. auch SpeichernUndLaden.LadeString())
        public static List<Fahrzeug> LadeFz(string path = "gespeicherteFahrzeuge.fz")
        {
            StreamReader reader = null;

            //Mittels der TypeNameHandling-Property des JsonSerializerSettings-Objekts kann dem Serialisierer aufgegeben werden, dass er den expliziten Objekt-Type der 
            //zu ladenden/speichernden Objekte mit abspeichert
            JsonSerializerSettings setting = new JsonSerializerSettings();
            setting.TypeNameHandling = TypeNameHandling.Objects;

            //Liste, in welche die geladenen Fahrzeuge geschrieben werden
            List<Fahrzeug> geladeneFahrzeuge = new List<Fahrzeug>();

            try
            {
                reader = new StreamReader(path);

                while (!reader.EndOfStream)
                {
                    //Auslesen einer Zeile der Datei
                    string aktuellesFahrzeugAlsString = reader.ReadLine();
                    //Umwandlung der Textzeile in ein Fahrzeug (Beachte die Übergabe des Settings-Objekts)
                    Fahrzeug aktuellesGeladenesFahrzeug = JsonConvert.DeserializeObject<Fahrzeug>(aktuellesFahrzeugAlsString, setting);
                    //Hinzufügen des Fahrzeugs zur Liste
                    geladeneFahrzeuge.Add(aktuellesGeladenesFahrzeug);
                }

                Console.WriteLine("Fahrzeuge erfolgreich geladen");
            }
            catch
            {
                Console.WriteLine("Laden fehlgeschlagen");
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            //Rückgabe der Liste an den Aufrufer
            return geladeneFahrzeuge;
        }

        //Mittels des OPERATOR-Stichworts können für einzelne Klassen Operatoren definiert werden
        //(Für Verwendung siehe TesteFahrzeugpark)
        public static bool operator ==(Fahrzeug fz1, Fahrzeug fz2)
        {
            return fz1.Equals(fz2);
        }

        public static bool operator !=(Fahrzeug fz1, Fahrzeug fz2)
        {
            return !fz1.Equals(fz2);
        }

        #endregion

        #region Felder / Properties
        //FELDER (Membervariablen) sind die Variablen einzelner Objekte, welche die Zustände dieser Objekte definieren
        private int maxGeschwindigkeit;
        //EIGENSCHAFTEN (Properties) definieren mittels Getter/Setter den Lese-/Schreibzugriff für jeweils ein Feld.
        ///In den Eigenschaften können bestimmte Bedingungen für das Lesen und Schreiben der Felder gesetzt werden, sowie der Zugriff
        ///für Lesen und Schreiben einzeln angepasst werden
        public int MaxGeschwindigkeit
        {
            get
            {
                return maxGeschwindigkeit;
            }

            private set
            {
                //Das Schlüsselwort VALUE beschreibt in einer Set-Methode den übergebenen Wert
                if (value >= 0)
                    maxGeschwindigkeit = value;
            }
        }
        //Wird in einer Eigenschaft keine Spezifizierung angegeben, generiert das Programm das entsprechende Feld unsichtbar im Hintergrund
        public int AktGeschwindigkeit { get; private set; }
        public string Name { get; set; }
        public decimal Preis { get; private set; }
        public bool MotorLäuft { get; private set; } //:= Zustand 
        #endregion

        #region Konstruktor/Destruktor
        //KONSTRUKTOREN sind spezielle Methoden, welche ein neues Objekt instanziiert und den Anfangszustand festlegt. Sie definieren sich
        ///durch den Namen (derselbe, wie die Klasse) und den nicht vorhandenen Rückgabetyp (nicht mal void)
        public Fahrzeug(string name, int maxG, decimal preis)
        {
            this.MaxGeschwindigkeit = maxG;
            this.Name = name;
            this.Preis = preis;
            this.AktGeschwindigkeit = 0;
            this.MotorLäuft = false;

            AnzahlFahrzeuge++;
        }

        //Es können mehrere Konstruktoren definiert werden, welche unterschiedliche Übergabeparameter haben (Überladung). Ein Konstruktor, der keine
        //Übergabeparameter hat, wird als Basiskonstruktor bezeichnet
        public Fahrzeug()
        {

        }

        //Der DESTRUKTOR wird von der GarbageCollection aufgerufen, wenn ein Objekt aus dem Speicher gelöscht wird. Der Destruktor wird 
        ///automatisch (unsichtbar) erzeugt und muss nur selbst geschrieben werden, wenn neben der Objektzerstörung noch andere Anweisungen
        ///ausgeführt werden sollen.
        ~Fahrzeug()
        {
            Console.WriteLine($"{this.Name} wurde zerstört.");
        }
        #endregion

        #region Membermethoden
        //MEMBERMETHODEN sind Funktionen, welche jedes Objekt einer Klasse besitzt und speziell dieses Objekt manipuliert
        public void Beschleunige(int a)
        {
            if (this.MotorLäuft)
            {
                if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
                    this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
                else if (this.AktGeschwindigkeit + a < 0)
                    this.AktGeschwindigkeit = 0;
                else
                    this.AktGeschwindigkeit += a;
            }
            else
                Console.WriteLine($"Der Motor von {this.Name} läuft nicht.");
        }

        public void MotorStarten()
        {
            if (this.MotorLäuft)
                Console.WriteLine($"Der Motor von {this.Name} läuft bereits.");
            else
                this.MotorLäuft = true;
        }

        public void MotorStoppen()
        {
            if (this.MotorLäuft)
            {
                this.MotorLäuft = false;
                this.AktGeschwindigkeit = 0;
            }
            else
                Console.WriteLine($"Der Motor von {this.Name} ist bereits aus.");
        }

        //Eine als VIRTUAL gesetzte Methode erlaubt den Kindklassen diese per OVERRIDE zu überschreiben
        public virtual string BeschreibeMich()
        {
            if (this.MotorLäuft)
                return $"{this.Name} bewegt sich mit {this.AktGeschwindigkeit} von {this.MaxGeschwindigkeit}km/h und kostet {this.Preis} Euro.";
            else
                return $"{this.Name} könnte sich mit {this.MaxGeschwindigkeit}km/h bewegen und kostet {this.Preis} Euro.";
        }

        //Die ToString()-Methode wird von der object-Klasse an alle anderen Klassen vererbt. Sie wird immer dann aufgerufen, wenn ein Objekt als
        //String dargestellt werden soll
        public override string ToString()
        {
            return this.BeschreibeMich();
        }
        
        //Eine als ABSTRACT gesetzte Methode (nur in abstrakten Klassen möglich) beseht nur aus einem Methodenkopf und zwingt erbende
        //Klassen diese Methode zu implementieren
        public abstract void Hupen();

        //Durch IClonable geforderte Methode
        public object Clone()
        {
            //MemberwiseClone() erzeugt eine Kopie des aktuellen Objekts, wobei allerdings nur Wertetypen kopiert werden. Referenztypen, 
            //welche ebenfalls kopiert werden sollen, benötigen ebenfalls die Implementierung des IClonable-Interfaces, wobei dann hier
            //die Clone()-Methode der zu kopierenden Klasse aufgerufen werden muss.
            return this.MemberwiseClone();
        }

        //Als Alternative zum IClonable-Interface kann auch ein Kopierkonstruktor geschrieben werden
        public Fahrzeug(Fahrzeug fz)
        {
            this.Name = fz.Name;
            this.Preis = fz.Preis;
            this.MaxGeschwindigkeit = fz.MaxGeschwindigkeit;
            this.AktGeschwindigkeit = fz.AktGeschwindigkeit;
            this.MotorLäuft = fz.MotorLäuft;
        }
        #endregion



    }
}
