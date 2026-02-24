using NUnit.Framework;
using task1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void MaxDigitStart()
        {
            var threeDigitNumber = 321;
            var answer = Logic.CompareDigit(threeDigitNumber);
            
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(3,answer);
        }
        [TestMethod()]
        public void MaxDigitMiddle()
        {
            var threeDigitNumber = 132;
            var answer = Logic.CompareDigit(threeDigitNumber);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(3, answer);
        }
        [TestMethod()]
        public void MaxDigitEnd()
        {
            var threeDigitNumber = 123;
            var answer = Logic.CompareDigit(threeDigitNumber);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(3, answer);
        }
        [TestMethod()]
        public void DigitEqually()
        {
            var threeDigitNumber = 555;
            var answer = Logic.CompareDigit(threeDigitNumber);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(5, answer);
        }
    }
}
