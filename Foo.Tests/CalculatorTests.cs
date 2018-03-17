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
    }
}
