using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Model.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void CanInitializeCalculator()
        {
            var calculator = new Calculator();
        }
        
        [Test]
        public void OnePlusOne()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate(1, 1);
            Assert.AreEqual(2, result); 
        }
    }
}
