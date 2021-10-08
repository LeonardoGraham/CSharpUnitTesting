using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase (-1)]
        [TestCase (301)]
        public void CalculateDemeritPoints_InputIsOutOfRange_ThrowArgumentOutRangeExemption(int speed)
        {
            Assert.That(() => _calculator.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0)]
        [TestCase(64)]
        [TestCase(65)]
        [TestCase(69)]
        public void CalculateDemeritPoints_WhenCalled_ReturnZeroDemeritPoints(int speed)
        {
            var result = _calculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_InputIsOverSpeedLimit_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var result = _calculator.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
