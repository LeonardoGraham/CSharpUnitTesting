using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class CustomerControllerTests
    {
        private CustomerController _controller;
        [SetUp]
        public void SetUp()
        {
            _controller = new CustomerController();
        }
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var result = _controller.GetCustomer(0);

            // Asserts that result is of type NotFound
            Assert.That(result, Is.TypeOf<NotFound>());

            //// Asserts that result is of type NotFound or one of its derivaties
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        { }
    }
}
