using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    //vgl. PKW
    public class Schiff : Fahrzeug, IBeladbar
    {
        public int AnzahlBesatzung { get; set; }
        public Fahrzeug Ladung { get; set; }

        public Schiff(string name, int maxG, decimal preis, int anzCrew) : base(name, maxG, preis)
        {
            this.AnzahlBesatzung = anzCrew;
        }

        public override void Hupen()
        {
            Console.WriteLine("Trööööt");
        }

        public override string BeschreibeMich()
        {
            if(this.Ladung == null)
                return "Das Schiff " + base.BeschreibeMich() + $" Es hat {this.AnzahlBesatzung} Mann Besatzung und nichts geladen.";
            else
                return "Das Schiff " + base.BeschreibeMich() + $" Es hat {this.AnzahlBesatzung} Mann Besatzung und {this.Ladung.Name} geladen.";
        }

        public void Belade(Fahrzeug fz1)
        {
            if (this.Ladung == null)
            {
                this.Ladung = fz1;
                Console.WriteLine($"{this.Ladung.Name} wurde auf {this.Name} geladen.");
            }
            else
                Console.WriteLine($"{this.Name} hat bereits {this.Ladung.Name} geladen.");
        }

        public void Entlade()
        {
            if (this.Ladung != null)
            {
                Console.WriteLine($"{this.Ladung.Name} wurde von {this.Name} entladen.");
                this.Ladung = null;
            }
            else
                Console.WriteLine($"{this.Name} hat keine Ladung, die entladen werden könnte.");
        }
    }
}
