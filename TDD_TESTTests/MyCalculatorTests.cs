using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_TEST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;

namespace TDD_TEST.Tests
{
    [TestClass()]
    public class MyCalculatorTests
    {
        [TestMethod()]
        public void CostAddTest()
        {
            //arrange
            var target = new MyCalculator();
            var expected = new List<int> {6,15,24,21};
            var actual = new List<int> { };

            //act
            actual = target.costAdd();

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void RevenueAddTest()
        {
            //arrange
            var target = new MyCalculator();
            var expected = new List<int> { 50, 66, 60 };
            var actual = new List<int> { };

            //act
            actual = target.revenueAdd();

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}