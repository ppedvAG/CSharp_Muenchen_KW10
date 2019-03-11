using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fahrzeugpark;

namespace TesteFahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Modul04 - OOP
            ////Instatierung von Fahrzeugen
            //Fahrzeug fz = new Fahrzeug("BMW", 270);
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 310);

            ////Ausgabe der Maximalgeschwindigkeit von fz
            //Console.WriteLine(fz.MaxGeschwindigkeit);

            ////Änderung des Namens von fz1
            //fz.Name = "VW";

            ////Ausgabe der BeschreibeMich()-Methoden der Fahrzeuge
            //Console.WriteLine(fz.BeschreibeMich());
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Aufruf der MotorStarten()-Methode
            //fz.MotorStarten()

            ////Neuzuweisung der fz1-Variable auf Objekt in fz-Variable
            //fz1 = fz;

            ////Manueller Aufruf der Garbage Collection
            //GC.Collect();
            #endregion

            #region Lab04 Fahrzeug_Klasse
            ////Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            ////Ausführen der BeschreibeMich()-Methode des Fahrzeugs und Ausgabe in der Konsole
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Diverse Methodenausführungen
            //fz1.MotorStarten();
            //fz1.Beschleunige(120);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.Beschleunige(300);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.MotorStoppen();
            //Console.WriteLine(fz1.BeschreibeMich());
            #endregion

            #region Modul 05 - Vererbung
            //PKW pkw1 = new PKW("BMW", 220, 16000, PKW.PKWTreibstoff.Benzin);
            //PKW pkw2 = new PKW("BMW", 220, 16000, PKW.PKWTreibstoff.Benzin);
            //PKW pkw3 = new PKW("BMW", 220, 16000, PKW.PKWTreibstoff.Benzin);
            //PKW pkw4 = new PKW("BMW", 220, 16000, PKW.PKWTreibstoff.Benzin);

            //Console.WriteLine(pkw1);

            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge); 
            #endregion

            #region Lab05 - PKW-, Schiff, Flugzeug-Klasse
            //PKW pkw1 = new PKW("BMW", 250, 23000, PKW.PKWTreibstoff.Benzin);
            //Schiff schiff1 = new Schiff("Titanic", 50, 2600000, 900);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 990, 3600000, 9800);

            //Console.WriteLine(pkw1.BeschreibeMich());
            //Console.WriteLine(schiff1.BeschreibeMich());
            //Console.WriteLine(flugzeug1.BeschreibeMich());

            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge);

            //schiff1.MotorStarten();
            //schiff1.Beschleunige(30);

            //Console.WriteLine(schiff1.BeschreibeMich()); 
            #endregion

            #region Modul06 - Intefaces und Polymorphismus
            //PKW pkw1 = new PKW("BMW", 290, 36000, PKW.PKWTreibstoff.Benzin);
            //Schiff schiff1 = new Schiff("Titanic", 50, 2600000, 900);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 990, 3600000, 9800);

            //Fahrzeug fz1 = pkw1;

            //IBewegbar bewegbaresObjekt = pkw1;

            //ÄndereName(pkw1);
            //ÄndereName(schiff1);
            //ÄndereName(flugzeug1);

            //RadAb(pkw1);
            //RadAb(flugzeug1); 
            #endregion

            #region Lab06 - IBeladbar
            //PKW pkw1 = new PKW("BMW", 290, 36000, PKW.PKWTreibstoff.Benzin);
            //Schiff schiff1 = new Schiff("Titanic", 50, 2600000, 900);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 990, 3600000, 9800);

            //BeladeFahrzeuge(pkw1, flugzeug1);
            //BeladeFahrzeuge(schiff1, flugzeug1);
            //BeladeFahrzeuge(pkw1, schiff1);

            //Console.WriteLine("\n" + schiff1.BeschreibeMich()); 
            #endregion

            #region Modul07 - Generische Listen
            //List<string> stringliste = new List<string>();

            //Console.WriteLine(stringliste.Count);

            //stringliste.Add("Eintrag 1");
            //stringliste.Add("Eintrag 2");
            //stringliste.Add("Eintrag 3");
            //stringliste.Add("Eintrag 4");
            //stringliste.Add("Eintrag 5");

            //Console.WriteLine(stringliste.Count);

            //foreach (var item in stringliste)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(stringliste[2]);

            //stringliste.RemoveAt(2);

            //foreach (var item in stringliste)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Fahrzeug> fzListe = new List<Fahrzeug>();

            //PKW pkw1 = new PKW("BMW", 290, 36000, PKW.PKWTreibstoff.Benzin);
            //fzListe.Add(pkw1);
            //fzListe.Add(new Flugzeug("Boing", 3000, 2600000, 9999));

            //foreach (var item in fzListe)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //List<List<string>> mehrdimensionaleListe = new List<List<string>>();
            //string eintrag = mehrdimensionaleListe[1][2];

            //Dictionary<int, string> dict1 = new Dictionary<int, string>();

            //dict1.Add(10, "Hallo");
            //dict1.Add(20, "Ciao");
            //dict1.Add(30, "Moin");

            //Console.WriteLine(dict1[20]);

            //foreach (var item in dict1)
            //{
            //    Console.WriteLine(item.Key + ": " + item.Value);
            //} 
            #endregion

            #region Lab07 - Zufällige Fahrzeuglisten
            ////Variablendeklaration und -initialisierung
            //Queue<Fahrzeug> fzQueue = new Queue<Fahrzeug>();
            //Stack<Fahrzeug> fzStack = new Stack<Fahrzeug>();
            //Dictionary<Fahrzeug, Fahrzeug> fzDict = new Dictionary<Fahrzeug, Fahrzeug>();
            //Random generator = new Random();
            //int AnzahlFz = 100000;

            ////Schleife zur Zufälligen Befüllung von Queue und Stack
            //for (int i = 0; i < AnzahlFz; i++)
            //{
            //    switch (generator.Next(1, 4))
            //    {
            //        case 1:
            //            fzQueue.Enqueue(new PKW("BMW", 260, 30000, PKW.PKWTreibstoff.Benzin));
            //            fzStack.Push(new PKW("BMW", 260, 30000, PKW.PKWTreibstoff.Benzin));
            //            break;
            //        case 2:
            //            fzQueue.Enqueue(new Schiff("Titanic", 60, 26000000, 900));
            //            fzStack.Push(new Schiff("Titanic", 60, 26000000, 900));
            //            break;
            //        case 3:
            //            fzQueue.Enqueue(new Flugzeug("Boing", 980, 6000000, 10050));
            //            fzStack.Push(new Flugzeug("Boing", 980, 6000000, 10050));
            //            break;
            //    }
            //}

            ////Schleife zur Prüfung auf das Interface und Befüllung des Dictionaries
            //for (int i = 0; i < AnzahlFz; i++)
            //{
            //    //Prüfung, ob das Interface vorhanden ist (mittels Peek(), da die Objekte noch benötigt werden)...
            //    if (fzQueue.Peek() is IBeladbar)
            //    {
            //        //...wenn ja, dann Cast in das Interface und Ausführung der Belade()-Methode (mittels Peek())...
            //        ((IBeladbar)fzQueue.Peek()).Belade(fzStack.Peek());
            //        //...sowie Hinzufügen zum Dictionary (mittels Pop()/Dequeue(), um beim nächsten Durchlauf andere Objekte an den Spitzen zu haben)
            //        fzDict.Add(fzQueue.Dequeue(), fzStack.Pop());
            //    }
            //    else
            //    {
            //        //... wenn nein, dann Löschung der obersten Objekte (mittels Pop()/Dequeue())
            //        fzQueue.Dequeue();
            //        fzStack.Pop();
            //    }
            //}

            ////Programmpause
            //Console.ReadKey();
            //Console.WriteLine("\n----------LADELISTE----------");

            ////Schleife zur Ausgabe des Dictionaries
            //foreach (var item in fzDict)
            //{
            //    Console.WriteLine($"'{item.Key.Name}' hat '{item.Value.Name}' geladen.");
            //} 
            #endregion

            #region Modul10 - Serialisierung und Abspeichern von Fahrzeugen
            //List<Fahrzeug> listeZumAbspeichern = new List<Fahrzeug>();

            //listeZumAbspeichern.Add(new PKW("BMW", 290, 36000, PKW.PKWTreibstoff.Benzin));
            //listeZumAbspeichern.Add(new Flugzeug("Boing", 3000, 2600000, 9999));
            //listeZumAbspeichern.Add(new Schiff("Titanic", 60, 6000000, 900));

            //Fahrzeug.SpeichereFz(listeZumAbspeichern);

            //List<Fahrzeug> geladeneFahrzeugListe = Fahrzeug.LadeFz();
            //foreach (var item in geladeneFahrzeugListe)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Zusätzliches

            //Vorbereitung
            Random generator = new Random();
            Flugzeug fz = new Flugzeug("Boing", 999, 500000000, 9999);
            Flugzeug fz2 = fz;
            fz.Passagierliste.Add("Hugo");
            fz.Passagierliste.Add("Anna");
            fz.Passagierliste.Add("Otto");

            //Bsp für die Verwendung der Indexer-Property (siehe Fahrzeugpark.Flugzeug)
            Console.WriteLine(fz[2]);

            //Bsp für die Verwendung von IEnumerable (siehe Fahrzeugpark.Flugzeug)
            foreach (var item in fz)
            {
                Console.WriteLine(item);
            }

            //Bsp für die Verwendung von eigenen definierten Operatoren (siehe Fahrzeugpark.Fahrzeug)
            Console.WriteLine(fz == fz2);
            Console.WriteLine(fz == new Flugzeug("Boing", 999, 500000000, 9999));

            //Bsp für die Verwendung einer Erweiterungsmethode (s.u.)
            Console.WriteLine(generator.NextInclusive(12, 45));

            #endregion

            //Programmpause
            Console.ReadKey();
        }

        //Methode - Lab06
        public static void BeladeFahrzeuge(Fahrzeug fz1, Fahrzeug fz2)
        {
            if (fz1 is IBeladbar)
            {
                ((IBeladbar)fz1).Belade(fz2);
            }
            else if (fz2 is IBeladbar)
            {
                (fz2 as IBeladbar).Belade(fz1);
            }
            else
            {
                Console.WriteLine("Kein Fahrzeug kann ein anderes Fahrzeug aufladen.");
            }
        }

        #region Bsp-Methoden Modul06
        public static void RadAb(IBewegbar bewegbarsO)
        {
            bewegbarsO.RäderAnzahl--;

            if (bewegbarsO is PKW)
            {
                PKW pkw1 = (PKW)bewegbarsO;
                Console.WriteLine(pkw1.Treibstoff);

                Console.WriteLine(((PKW)bewegbarsO).Treibstoff);
            }
        }

        public static void ÄndereName(Fahrzeug fz1)
        {
            fz1.Name = "VW";
        }
        #endregion

    }

    public static class Hilfmethoden
    {
        //Mittels des THIS-Stichworts in der Parameterübergabe kann eine Methode als Erweiterungsmethode einer Klasse definiert
        //werden. Diese muss in einer statischen Klasse beschrieben werden und wird dann als Teil der zugeordneten Klasse betrachtet.
        public static int NextInclusive(this Random generator, int a, int b)
        {
            return generator.Next(a, b + 1);
        }
    }
}
