using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CalcAppDebug.Program;

namespace CalcAppDebug.test
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void TestAdd3and7()
        {
            // 3 + 7 = 10
            double a = 3.0;
            double b = 7.0;
            double expected = 10.0;

            Calculator calc = new Calculator();
            double actual = calc.Add(a, b);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestAdd5and23()
        {
            // 3 + 7 = 10
            double a = 5.0;
            double b = 23.0;
            double expected = 28.0;

            Calculator calc = new Calculator();
            double actual = calc.Add(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMul4and5()
        {
            double a = 4.0;
            double b = 5.0;
            double expected = 20.0;

            Calculator calc = new Calculator();
            double actual = calc.Mul(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDiv10and5()
        {
            double a = 10.0;
            double b = 5.0;
            double expected = 2.0;

            Calculator calc = new Calculator();
            double actual = calc.Div(a, b);

            Assert.AreEqual(expected, actual);
        }
    }
}
