using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemperatureLibrary;

namespace TemperatureLibrary.Test
{
    [TestClass]
    public class TemperatureTest
    {
        [TestMethod]
        public void TestIsSottoZero()
        {
            int num = 2;
            bool asp = false;
            bool resp = Temperature.IsSottoZero(num);
            Assert.AreEqual(asp, resp);
        }

        [DataTestMethod]
        [DataRow(2, false)]
        [DataRow(-1, true)]
        public void DataTestIsSottoZero(int num, bool asp)
        {
            bool resp = Temperature.IsSottoZero(num);
            Assert.AreEqual(asp, resp);
        }

        [TestMethod]
        public void TestContaSottoZero()
        {
            int[] num = new int[] {-1, 3,5, -3};
            int asp = 2;
            int resp = Temperature.ContaSottoZero(num);
            Assert.AreEqual(asp, resp);
        }

        [DataTestMethod]
        [DataRow(new int[] { -1, 3, 5, -3 }, 2)]
        [DataRow(new int[] { -1, -3, -5, 7 }, 3)]
        public void DataTestContaSottoZero(int[] num, int asp)
        {
            int resp = Temperature.ContaSottoZero(num);
            Assert.AreEqual(asp, resp);
        }

        [TestMethod]
        public void TestMinime()
        {
            int[] num = new int[] { -1, 3, 5, -3 };
            int[] asp = new int[] { -1, -3 };
            int[] resp = Temperature.Minime(num);
            CollectionAssert.AreEquivalent(asp, resp);
        }

        [DataTestMethod]
        [DataRow(new int[] { -1, 3, 5, -3 }, new int[] { -1, -3})]
        [DataRow(new int[] { -1, -3, -5, 7 }, new int[]{-1, -3, -5})]
        public void DataTestMinime(int[] num, int[] asp)
        {
            int[] resp = Temperature.Minime(num);
            CollectionAssert.AreEquivalent(asp, resp);
        }
    }
}
