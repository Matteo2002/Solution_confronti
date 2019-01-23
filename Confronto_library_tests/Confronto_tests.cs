using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Confronto_library;

namespace Confronto_library_tests
{
    [TestClass]
    public class Confronto_tests
    {
        [TestMethod]
        public void TestMax()
        {
            int n1 = 0;
            int n2 = 7;
            int max_aspettato = 7;

            int max_calcolato = Confronto.Max(n1, n2);
            Assert.AreEqual(max_aspettato, max_calcolato);

        }
        [TestMethod]
        public void TestMax1()
        {
            int n1 = 5;
            int n2 = 3;
            int max_aspettato = 5;

            int max_calcolato = Confronto.Max(n1, n2);
            Assert.AreEqual(max_aspettato, max_calcolato);

          
        }
    }
}
