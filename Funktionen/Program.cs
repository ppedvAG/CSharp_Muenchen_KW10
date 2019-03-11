using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen
{
    class Program
    {
        //Jede Funktion/Methode besteht aus einem Kopf und einem Körper
        ///Der Kopf besteht aus den MODIFIERN (public static), dem RÜCKGABEWERT (int), dem NAMEN (Addiere) sowie den ÜBERGABEPARAMETERN
        ///Wird einem Parameter mittels =-Zeichen ein Defaultwert zugewiesen wird dieser Parameter OPTIONAL und muss bei Aufruf nicht zwangs-
        ///läufig mitgegeben werden. OPTIONALE Parameter müssen am Ende der Parameter stehen.
        public static int Addiere(int a, int b, int c = 0)
        {
            //Der RETURN-Befehl weist die Methode an einen Wert als Rückgabewert an den Aufrufe zurückzugeben
            return a + b + c;
        }

        //Funktion, welche den gleichen Bezeichner haben, nennt man ÜBERLADENE Funktionen. Diese müssen sich in Anzahl und/oder Art der 
        ///Übergabeparameter unterscheiden, damit der Aufruf eindeutig ist.
        public static double Addiere(double a, double b)
        {
            return a + b;
        }

        //Mittels des PARAMS-Stichwort kann einer Funktion eine beliebige Anzahl von gleichartigen Werten übergeben
        /// werden. Diese werden Funktionsintern als Array dieses Datentyps behandelt.
        public static int Addiere(params int[] summanden)
        {
            return summanden.Sum();
        }

        //Das OUT-Stichwort ermöglich einer Methode mehr als einen Rückgabewert zu haben. Dabei kann die Variable direkt in der Funktions-
        ///übergabe deklariert werden
        public static int AddiereUndSubtrahiere(int a, int b, out int differenz)
        {
            differenz = a - b;
            return a + b;
        }


        static void Main(string[] args)
        {
            //Funktionsaufruf mit drei Übergabeparametern und Speichern des Rückgabewerts
            int summe = Addiere(12, 45, 456);
            //Ausgabe
            Console.WriteLine(summe);

            //Aufruf der selben Funktion mit nur zwei Übergabeparametern (möglich, da der dritte Parameter optional ist)
            summe = Addiere(5, 6);

            //Aufruf der Double-Überladung der Funktion
            double summe2 = Addiere(12.5, 45.6);

            //Aufruf der params-Funktion (beliebige Anzahl von Integer-Werten wird intern in Array umgewandelt)
            summe = Addiere( 1, 2, 6, 5, 7, 8, 9);

            //Aufruf der Out-Funktion (in 'summe' steht die Summe der Zahlen und in 'diff' die Differenz)
            summe = AddiereUndSubtrahiere(12, 10, out int diff);
            //Ausgabe
            Console.WriteLine(summe);
            Console.WriteLine(diff);

            //TryParse() als Bsp für Out-Verwendung
            if (int.TryParse(Console.ReadLine(), out int result))
                Console.WriteLine(result*2);

            //Programmpause
            Console.ReadKey();
        }
    }
}
