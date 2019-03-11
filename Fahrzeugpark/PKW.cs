using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //PKW erbt mittels des :-Zeichens von der Fahrzeug-Klasse und übernimmt somit alle Eigenschaften und Methoden von dieser. Zusätzlich
    ///implementiert diese Klasse das Interface IBewegbar.
    public class PKW : Fahrzeug, IBewegbar
    {
        //Fahrzeug-eigener Enumerator
        public enum PKWTreibstoff { Benzin, Diesel, Elektro, Hybrid}

        //Zusätzliche PKW-eigene Eigenschaft
        public PKWTreibstoff Treibstoff { get; set; }
        //Durch das Interface verlangte Eigenschaft
        public int RäderAnzahl { get; set; }

        //PKW-Konstruktor, welcher per BASE-Stichwort den Konstruktor der Fahrzeugklasse aufruft. Dieser erstellt dann ein Fahrzeug, gibt dies
        ///an diesen Konstruktor zurück, welcher dann die zusätzlichen Eigenschaften einfügt
        public PKW(string name, int maxG, decimal preis, PKWTreibstoff treibstoff) : base(name, maxG, preis)
        {
            this.Treibstoff = treibstoff;
            this.RäderAnzahl = 4;
        }

        //Per OVERRIDE werden virtuelle und abstrakte Methoden der Mutterklasse überschrieben. Bei dem Methodenaufruf wir die Methode der
        ///Kindklasse aufgerufen
        public override string BeschreibeMich()
        {
            //Mittels des BASE-Stichworts wird auf die Methode der Mutterklasse zugegriffen
            return "Der PKW " + base.BeschreibeMich() + $" Er fährt mit {this.Treibstoff}.";
        }

        //Durch Mutterklasse geforderte (weil als ABSTRACT gesetzte) Funktion
        public override void Hupen()
        {
            Console.WriteLine("HupHup");
        }

        //Durch das Interface verlangte Methode
        public void Crash()
        {
            Console.WriteLine("Du hast den Baum übersehen");
            this.RäderAnzahl--;
        }

        //Statische Methode (gilt für die gesamte Klasse) zur Erstellung eines zufälligen PKWs 
        private static Random generator = new Random();
        public static PKW ErzeugeZufälligenPKW(string plusName = "")
        {
            string name;
            switch (generator.Next(1, 5))
            {
                case 1:
                    name = "BMW" + plusName;
                    break;
                case 2:
                    name = "Mercedes" + plusName;
                    break;
                case 3:
                    name = "Audi" + plusName;
                    break;
                default:
                    name = "VW" + plusName;
                    break;
            }
            return new PKW(name, generator.Next(15, 31) * 10, generator.Next(15, 30) * 1000, (PKWTreibstoff)generator.Next(0, 5));
        }
    }
}
