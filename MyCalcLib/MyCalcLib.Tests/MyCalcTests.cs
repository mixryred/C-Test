using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcLib.Tests
{
    [TestClass]
    public class MyCalcTests
    {
        [TestMethod]
        public void Sum_30and40_70returned()
        {
            int x = 30;
            int y = 40;
            int expected = 70;

            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
