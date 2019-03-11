using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung von Beispiel-Variablen
            bool t = true;
            bool f = false;

            //IF-ELSEIF-ELSE-Block
            ///Das Programm wird (nur) den ersten Block ausführen, bei welchem er auf eine wahre Bedingung trifft und dann am Ende des Blocks mit
            ///dem Code weiter machen
            if (t)
            {
                Console.WriteLine("t ist wahr");
            }
            //Es kann beliebig viele ELSE-IF-Blöcke geben
            else if (f)
            {
                Console.WriteLine("t ist unwahr und f ist wahr");
            }
            //Wenn keine der Bedingungen wahr ist, wird der (optionale) ELSE-Block ausgeführt
            else
            {
                Console.WriteLine("t und f sind unwahr");
            }

            //WHILE-Schleife
            ///Die WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein unwahr, dann wird die Schleife
            ///übersprungen
            while (true)
            {
                Console.WriteLine("Hallo");
                //Mit der BREAK-Anweisung wird die Schleife verlassen und der Code wird fortgesetzt.
                break;
            }

            //DO-WHILE-Schleife
            ///Auch die DO-WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Allerdings wird die Bedingung erst am Schleifen_
            ///ende geprüft, weshalb die Schleife mindestens einmal durchläuft.
            do
            {
                Console.WriteLine("Ciao");
                //Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und lässt erneut die Bedingung prüfen. Ist die Bedingung wahr
                ///beginnt ein neuer Durchlauf
                continue;
                Console.WriteLine("Wird niemals angezeuigt");

            } while (f);


            //FOR-Schleife
            ///Der FOR-Schleife wird ein Laufindex (i) sowie eine Bedingung und eine Anweisung übergeben. Am Ende jedes Durchlaufes wird die
            ///Anweisung ausgeführt. Wenn die Bedingung nicht (mehr) wahr ist, wird kein (weiterer) Schleifendurchlauf begonnen.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + ". Durchlauf");
                i++;
            }

            //ARRAYS
            ///Arrays sind Collections, welche mehrere Variablen eines Datentyps speichern können. Die Größe des Arrays muss bei der
            ///Initialisierung entweder durch eine Zahl oder durch eine bestimmte Anzahl von spezifischen Elementen definiert werden.
            int[] zahlenArray = { 1, 4, 5, 73, 8, 45, 1234, 32 };

            //Der Zurgiff auf einzelne Array-Positionen erfolgt durch einen Nullbasierten Index
            Console.WriteLine(zahlenArray[3]);

            zahlenArray[3] = 465;
            Console.WriteLine(zahlenArray[3]);

            //Iteration über ein Array mittels For-Schleife
            for (int i = 0; i < zahlenArray.Length; i++)
            {
                Console.WriteLine(zahlenArray[i]);
            }

            //FOREACH-Schleifen können über Collections laufen und sprechen dabei jedes Element genau einmal an
            foreach (var item in zahlenArray)
            {
                Console.WriteLine(item);
            }

            //Strings können als Arrays von Chars betrachtet werden
            string begrüßung = "Guten Tag"; //<= char[]

            foreach (var item in begrüßung)
            {
                Console.WriteLine(item);
            }

            if (begrüßung[6] == 'T')
            {
                Console.WriteLine("Es ist ein T!");
            }

            //Mehrdimensionales Array
            int[,] zweiDimArray = new int[3, 5];

            zweiDimArray[0, 0] = 70;
            zweiDimArray[0, 1] = 12;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    zweiDimArray[i, j] = i + j;
                    Console.WriteLine(zweiDimArray[i, j]);
                }
            }

            //Basisdatentypen sind normalerweise nicht nullbar, d.h. bei der Deklaration wird ihnen ein Standartwert zugeordnet (z.B. int = 0, string = "")
            //Mittels des Nachstellen eines ? an den Datentyp erstellt man eine nullbare Variable dieses Typs

            //Nullbare Typen
            int? i_null;
            i_null = null;

            bool? b_null;
            b_null = null;

            double d;
            d = 0.0;

            char c;
            c = 'a';

            string s;
            s = "";
            s = string.Empty;

            //Null- und Leerprüfung eines Strings
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("String ist leer oder nicht vorhanden");
            }
            else
            {

            }

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
