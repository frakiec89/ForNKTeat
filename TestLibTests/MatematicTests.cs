using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib.Tests
{
    [TestClass()]
    public class MatematicTests
    {

        [TestMethod()]
        public void DelA_BTest_1_2____0_5()
        {
            Matematic m = new Matematic();
            int  a = 1;
            int b = 2;
            double expected = 0.5;
            var actual = m.DelA_B(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void DelA_BTest_4_2____2()
        {
            Matematic m = new Matematic();
            int a = 4;
            int b = 2;
            double expected = 2;
            var actual = m.DelA_B(a, b);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void DelA_BTest_min4_2____min2()
        {
            Matematic m = new Matematic();
            int a = -4;
            int b = 2;
            double expected = -2;
            var actual = m.DelA_B(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}