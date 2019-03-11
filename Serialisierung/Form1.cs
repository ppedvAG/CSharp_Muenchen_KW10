using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Fahrzeugpark;
using Newtonsoft.Json;

namespace Serialisierung
{
    public partial class Form1 : Form
    {
        public List<Fahrzeug> FzListe { get; set; }
        public Random generator { get; set; }

        public Form1()
        {
            InitializeComponent();

            //Initialisierung der Properties
            this.FzListe = new List<Fahrzeug>();
            this.generator = new Random();

            //Bsp für Darstellung eines Unicode-Zeichens
            LblMain.Text = "200\u20AC kosten die Schuhe";
        }

        //Click-Methoden der Buttons
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ErstelleNeuesFz();
            ZeigeFz();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            LöscheFz();
            ZeigeFz();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SpeichereFz();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            LadeFz();
            ZeigeFz();
        }

        //Methode zum Laden einer 'Fahrzeug'-Datei (vgl. auch SpeichernUndLaden.StringLaden() bzw Fahrzeugpark.Fahrzeug.LadeFz())
        private void LadeFz()
        {
            //Instanzierung eines Open-Dialogfensters 
            OpenFileDialog openDialog = new OpenFileDialog();

            //Einstellung diverser Parameter des Dialogfensters
            ///Standart-Dateiname
            openDialog.FileName = "textdatei.txt";
            ///Standart-Ordner (kann z.B. ein Pfad als String sein oder (wie hier) ein Windows-'SpecialFolder')
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ///Übergabe des Windows-Arbeitsplatzes als GUID
            openDialog.InitialDirectory = "::{20d04fe0-3aea-1069-a2d8-08002b30309d}";
            ///Mögliche Dateiformate
            openDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*";

            //Öffnen des Dialogfensters und Überprüfung der Benutzerwahl
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Öffen der LadeFz()-Methode mit Übergabe des gewählten Pfades
                List<Fahrzeug>tempFzList = Fahrzeug.LadeFz(openDialog.FileName);
                //Zusammenlegen zweier Listen
                FzListe.AddRange(tempFzList);
            }
        }

        //Methode zum Abspeichern von Fahrzeugen (vgl. auch LadeFZ)
        private void SpeichereFz()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "textdatei.txt";

            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveDialog.InitialDirectory = "::{20d04fe0-3aea-1069-a2d8-08002b30309d}";

            saveDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                List<Fahrzeug> tempFzList = new List<Fahrzeug>();

                //Iteration über die ListBox
                for (int i = 0; i < LbxFahrzeuge.Items.Count; i++)
                {
                    //Überprüfung, ob der aktuelle Eintrag vom Benutzer ausgewählt wurde
                    if (LbxFahrzeuge.GetSelected(i))
                    {
                        tempFzList.Add(FzListe[i]);
                    }
                }

                Fahrzeug.SpeichereFz(tempFzList, saveDialog.FileName);
            }
        }

        //Methode zum Löschen von Fahrzeugen
        private void LöscheFz()
        {
            for (int i = LbxFahrzeuge.Items.Count - 1; i >= 0; i--)
            {
                if (LbxFahrzeuge.GetSelected(i))
                    FzListe.RemoveAt(i);
            }
        }

        //Methode zur Darstellung der Fahrzeuge aus der Liste in der ListBox der GUI
        private void ZeigeFz()
        {
            LbxFahrzeuge.Items.Clear();

            foreach (var item in FzListe)
            {
                LbxFahrzeuge.Items.Add(item.Name);
            }

        }

        //Methode zur zufälligen Erstellung von Fahrzeugen
        private void ErstelleNeuesFz()
        {
            switch (generator.Next(1, 4))
            {
                case 1:
                    FzListe.Add(new Flugzeug($"Boing", 800, 3600000, 9999));
                    break;
                case 2:
                    FzListe.Add(new Schiff($"Titanic", 40, 3500000, 900));
                    break;
                case 3:
                    FzListe.Add(PKW.ErzeugeZufälligenPKW());
                    break;
            }
        }

        private void BtnSaveXml_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSeri = new XmlSerializer(typeof(PKW));

            FileStream file = File.Create("xmlFahrzeuge.xml");

            xmlSeri.Serialize(file, new PKW("Audi", 350, 41000, PKW.PKWTreibstoff.Benzin));

            file?.Close();
        }

        private void BtnLoadXml_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSeri = new XmlSerializer(typeof(PKW));

            FileStream file = File.Open("xmlFahrzeuge.xml", FileMode.Open);

            PKW pkw1 = (PKW)xmlSeri.Deserialize(file);

            MessageBox.Show(pkw1.ToString());

            file?.Close();
        }
    }
}
