namespace UnitTests
{
    [TestClass]
    public class PKW_Test
    {
        [TestMethod]
        public void Beschleunige_PKW_ueber_MaxG()
        {
            Fahrzeugpark.PKW pkw = new Fahrzeugpark.PKW("BMW", 230, 25000, 3);

            pkw.StarteMotor();
            pkw.Beschleunige(pkw.MaxGeschwindigkeit + 1);

            Assert.AreEqual(pkw.MaxGeschwindigkeit, pkw.AktGeschwindigkeit);
        }

        [TestMethod]
        public void Bremse_PKW_unter_0()
        {
            Fahrzeugpark.PKW pkw = new Fahrzeugpark.PKW("BMW", 230, 25000, 3);

            pkw.StarteMotor();
            pkw.Beschleunige(200);
            pkw.Beschleunige(-300);

            Assert.AreEqual(0, pkw.AktGeschwindigkeit);
        }
    }
}