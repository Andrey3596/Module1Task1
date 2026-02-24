using task1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestProject1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void MaxDigitStart()
        {
            var answer = Logic.CompareDigit(321);
            Assert.AreEqual(3,answer);
        }
        [TestMethod()]
        public void MaxDigitMiddle()
        {
            var answer = Logic.CompareDigit(132);
            Assert.AreEqual(3, answer);
        }
        [TestMethod()]
        public void MaxDigitEnd()
        {
            var answer = Logic.CompareDigit(123);
            Assert.AreEqual(3, answer);
        }
        [TestMethod()]
        public void DigitEqually()
        {
            var answer = Logic.CompareDigit(555);
            Assert.AreEqual(5, answer);
        }
    }
}
