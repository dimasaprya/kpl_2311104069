using Microsoft.VisualStudio.TestTools.UnitTesting;
using modul12_2311104069;

namespace modul12_2311104069_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPangkatNormal()
        {
            var form = new Form1();
            Assert.AreEqual(8, form.CariNilaiPangkat(2, 3));
        }

        [TestMethod]
        public void TestBZero()
        {
            var form = new Form1();
            Assert.AreEqual(1, form.CariNilaiPangkat(0, 0));
        }

        [TestMethod]
        public void TestBNegatif()
        {
            var form = new Form1();
            Assert.AreEqual(-1, form.CariNilaiPangkat(5, -2));
        }

        [TestMethod]
        public void TestInputOverLimit()
        {
            var form = new Form1();
            Assert.AreEqual(-2, form.CariNilaiPangkat(101, 2));
        }

        [TestMethod]
        public void TestOverflow()
        {
            var form = new Form1();
            Assert.AreEqual(-3, form.CariNilaiPangkat(100, 10));
        }
    }
}
