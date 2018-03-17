using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Foo.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void OnePlusTwo()
        {
            Assert.AreEqual(3, Calculator.Add(1, 2));
        }
        [Test]
        public void EvalOnePlusTwo()
        {
            Assert.AreEqual(3, Calculator.Eval("1 + 2"));
        }

        [TestCase("1 + 2", 3)]
        [TestCase("1 - 2", -1)]
        public void EvalOnePlusTwo(string text, int expected)
        {
            Assert.AreEqual(expected, Calculator.Eval(text));
        }
    }
}
