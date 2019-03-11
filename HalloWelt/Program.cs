//Mittels der USING-Anweisungen kann ein vereinfachter Zugriff auf Programm-Externe Klassen ermöglicht werden. 
///Es muss nun nicht mehr der vollständige Pfad angegeben werden, sondern es reicht der Klassenbezeichner.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NAMESPACE: Die Umgebung unseres aktuellen Programms: Alles innerhalb des Namespaces gehört zu dem Programm
namespace HalloWelt
{
    //Die PROGRAM-Klasse beinhaltet den Einstiegspunkt des Programms und muss in jedem C#-Programm vorhanden sein
    class Program
    {
        //Die MAIN()-Methode ist der Einstiegspunkt jedes C#-Programms: Hier beginnt das Programm IMMER
        static void Main(string[] args)
        {
            //Ausgabe eines String-Literals
            Console.WriteLine("Hello World");

            //Deklaration einer Integer-Variable 
            int alter;
            //Initialisierung der Integer-Variablen
            alter = 29;
            //Gleichzeitige Deklaration und Initialisierung einer String-Variablen
            string stadt = "Berlin";

            //Manipulation der Variablen
            alter = alter + 1;
            //Ausgabe der Variablen
            Console.WriteLine(alter);
            Console.WriteLine(stadt);
            //Manipulation der Ausgabe der Variablen
            Console.WriteLine(alter + 1);

            //Stringverkettungen:
            ///'traditionell' mittels +-Operator
            Console.WriteLine("Mein Name ist Klaas. Ich bin " + (alter + 1) + " Jahre alt und wohne in " + stadt + ".");
            ///Indexschreibweise (Platzhalter im String werden durch Variableninhalte ersetzt)
            Console.WriteLine("Mein Name ist Klaas. Ich bin {0} Jahre alt und wohne in {1} {{.", alter + 1, stadt);
            ///$-Operator (dynamische Inhalte werden dírekt in den String geschrieben)
            Console.WriteLine($"Mein Name ist Klaas. Ich bin {alter + 1} Jahre alt und wohne in {stadt}.");

            //Ausgabe einer Berchnung in Strings
            int a = 15;
            int b = 23;
            Console.WriteLine($"Das Ergebnis ist {a + b}");

            //String-Formatierung mittels Escape-Sequenzen
            string ausgabe = "Dies ist ein\nZeilenumbruch und dies ist ein \t horizontaler Tabulator. \\ \"  ";
            Console.WriteLine(ausgabe);

            //String-Formatierung mittels VerbaTim-String (Einleitung mittels @ / Escape-Sequenzen sind nicht möglich, 
            ///dynamische Inhalte mittels $ schon)
            ausgabe = $@"Dies ist ein
Zeilenumbruch und dies ist ein   horizontaler Tabulator. \ ";
            Console.WriteLine(ausgabe);

            //Eingabe eines Strings durch den Benutzer und Abspeichern in einer String-Variablen
            Console.WriteLine("Bitte gib einen String ein: ");
            string eingabe = Console.ReadLine();
            Console.WriteLine(eingabe);

            //Eingabe eines Strings, Umwandlung in einen Integer (Parse()-Funktion) und Abspeichern in einer Integer-Variablen
            Console.WriteLine("Bitte gib eine Zahl ein: ");
            int zahlAusEingabe = int.Parse(Console.ReadLine());
            Console.WriteLine(zahlAusEingabe * 50);

            //Programmpause
            Console.ReadKey();
        }
    }
}
