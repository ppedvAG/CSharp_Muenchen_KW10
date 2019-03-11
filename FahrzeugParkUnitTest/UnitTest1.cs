using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fahrzeugpark;

namespace FahrzeugParkUnitTest
{
    //UNIT-TESTS sind kleinteilige Software-Tests, welche jeweils zum Testen einer einzige Funktion gedacht sind. Ausgef�hrt werden sie
    ///�ber den Test-Explorer
    [TestClass]
    public class PKW_Test
    {
        [TestMethod]
        public void Beschleunige_PKW_�ber_Max_Geschwindigkeit()
        {
            PKW pkw = new PKW("VW", 280, 31000, PKW.PKWTreibstoff.Benzin);

            pkw.MotorStarten();

            pkw.Beschleunige(300);

            //Dies ASSERT-Klasse enth�lt diverse Vergleichsmethoden, welche in Unit-Tests verwendet werden k�nnen. Pro Test-Methode
            ///muss es mindesten einen Assert-Aufruf geben
            Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit);
        }

        [TestMethod]
        public void Beschleunige_PKW_�ber_Max_Geschwindigkeitt()
        {
            PKW pkw = new PKW("VW", 280, 31000, PKW.PKWTreibstoff.Benzin);

            pkw.MotorStarten();

            pkw.Beschleunige(300);

            Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit);
        }
    }
}
