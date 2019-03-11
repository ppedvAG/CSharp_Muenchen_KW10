using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //vgl auch PKW
    //Mittels des Interfaces IEnumerable kann eine Klasse dazu befähigt werden, die foreach-Schleife zu unterstützen. Dieses
    //Interface zwingt die implementierenden Klassen dazu die Methode GetEnumerator zu definieren, welche durch die Schleife
    //aufgerufen wird.
    public class Flugzeug : Fahrzeug, IBewegbar, IEnumerable
    {
        #region Properties
        public List<string> Passagierliste { get; set; }

        //Mittels der unten stehenden Indexer-Property kann eine Klasse befähigt werden, die Index-Scheibweise von z.B. den Array zu übernehmen
        //(Für Verwendung siehe TesteFahrzeugpark)
        public string this[int i]
        {
            get
            {
                return this.Passagierliste[i];
            }
            set
            {
                this.Passagierliste[i] = value;
            }
        }

        public int MaxFlughöhe { get; set; }
        public int RäderAnzahl { get; set; }
        #endregion

        #region Kontruktor und Methoden
        public Flugzeug(string name, int maxG, decimal preis, int maxFH) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = maxFH;
            this.RäderAnzahl = 8;

            this.Passagierliste = new List<string>();
        }

        //Durch IEnumerable verlangte Methode (Für Verwendung siehe TesteFahrzeugpark)
        public IEnumerator GetEnumerator()
        {
            foreach (var item in this.Passagierliste)
            {
                //Mittels des yield-Stichworts gibt diese Methode in jedem Durchlauf einen Wert zurück und wird nicht durch die Verwendung von Return beendet
                yield return item;
            }
        }

        public override string BeschreibeMich()
        {
            return "Das Flugzeug " + base.BeschreibeMich() + $" Es kann bis auf maximal {this.MaxFlughöhe}m aufsteigen.";
        }

        public override void Hupen()
        {
            Console.WriteLine("Piep");
        }

        public void Crash()
        {
            Console.WriteLine("Da war ein Vogel im Weg.");
        } 
        #endregion
    }
}
