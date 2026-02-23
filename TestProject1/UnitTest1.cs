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
        public void MaxStart()
        {
            var num = 321;
            var answer = Logic.Compare(num);
            
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(3,answer);
        }
        [TestMethod()]
        public void MaxMiddle()
        {
            var num = 132;
            var answer = Logic.Compare(num);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(3, answer);
        }
        [TestMethod()]
        public void MaxEnd()
        {
            var num = 123;
            var answer = Logic.Compare(num);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(3, answer);
        }
        [TestMethod()]
        public void Equally()
        {
            var num = 555;
            var answer = Logic.Compare(num);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(5, answer);
        }
    }
}
