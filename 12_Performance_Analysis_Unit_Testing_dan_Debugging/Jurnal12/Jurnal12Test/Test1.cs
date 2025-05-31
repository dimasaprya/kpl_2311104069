using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jurnal12;

namespace Jurnal12Tests
{
    [TestClass]
    public class UnitTest1
    {
        private Form1 form;

        [TestInitialize]
        public void Setup()
        {
            form = new Form1();
        }

        [TestMethod]
        public void TestCariNilaiPangkat_NormalCase()
        {
            // Test case normal: 2^3 = 8
            long result = form.CariNilaiPangkat(2, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestCariNilaiPangkat_PowerZero()
        {
            // Test case b = 0: hasilnya selalu 1
            long result1 = form.CariNilaiPangkat(5, 0);
            Assert.AreEqual(1, result1);

            // Test case khusus: 0^0 = 1 (sesuai aturan)
            long result2 = form.CariNilaiPangkat(0, 0);
            Assert.AreEqual(1, result2);
        }

        [TestMethod]
        public void TestCariNilaiPangkat_NegativePower()
        {
            // Test case b negatif: return -1
            long result = form.CariNilaiPangkat(2, -3);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestCariNilaiPangkat_BaseOver100()
        {
            // Test case a > 100: return -2
            long result = form.CariNilaiPangkat(101, 2);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestCariNilaiPangkat_PowerOver10()
        {
            // Test case b > 10: return -2
            long result = form.CariNilaiPangkat(2, 11);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestCariNilaiPangkat_BothLimitsExceeded()
        {
            // Test case a > 100 dan b > 10: return -2
            long result = form.CariNilaiPangkat(101, 11);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestCariNilaiPangkat_Overflow()
        {
            // Test case overflow: return -3
            // Contoh: nilai yang besar yang akan menyebabkan overflow
            long result = form.CariNilaiPangkat(100, 10);
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void TestCariNilaiPangkat_EdgeCases()
        {
            // Test case batas maksimal yang masih valid
            long result1 = form.CariNilaiPangkat(100, 1);
            Assert.AreEqual(100, result1);

            long result2 = form.CariNilaiPangkat(1, 10);
            Assert.AreEqual(1, result2);

            // Test case 0^n (n > 0)
            long result3 = form.CariNilaiPangkat(0, 5);
            Assert.AreEqual(0, result3);
        }

        [TestMethod]
        public void TestCariNilaiPangkat_SmallValidCases()
        {
            // Test berbagai kasus kecil yang valid
            Assert.AreEqual(1, form.CariNilaiPangkat(1, 5));
            Assert.AreEqual(4, form.CariNilaiPangkat(2, 2));
            Assert.AreEqual(27, form.CariNilaiPangkat(3, 3));
            Assert.AreEqual(256, form.CariNilaiPangkat(4, 4));
            Assert.AreEqual(3125, form.CariNilaiPangkat(5, 5));
        }

        [TestMethod]
        public void TestCariNilaiPangkat_LargeButValidCases()
        {
            // Test kasus yang besar tapi masih dalam batas
            Assert.AreEqual(32, form.CariNilaiPangkat(2, 5));
            Assert.AreEqual(729, form.CariNilaiPangkat(3, 6));
            Assert.AreEqual(16384, form.CariNilaiPangkat(4, 7));
        }

        [TestCleanup]
        public void Cleanup()
        {
            form?.Dispose();
        }
    }
}