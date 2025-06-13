using Microsoft.VisualStudio.TestTools.UnitTesting;
using tpmodul12_2311104069;

namespace tpmodul12_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNegatif()
        {
            Form1 form = new Form1();
            Assert.AreEqual("Negatif", form.CariTandaBilangan(-10));
        }

        [TestMethod]
        public void TestPositif()
        {
            Form1 form = new Form1();
            Assert.AreEqual("Positif", form.CariTandaBilangan(5));
        }

        [TestMethod]
        public void TestNol()
        {
            Form1 form = new Form1();
            Assert.AreEqual("Nol", form.CariTandaBilangan(0));
        }
    }
}
