using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests // Class Name + "Tests"
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue() // Method Name _ Scenarion _ Expected Behavior
        {
            // AAA
            // Arrange - Where we initialize our objects
            var reservation = new Reservation();

            // Act - Where we act on the object (call a method)
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert - Verifies that result is correct
            Assert.That(result, Is.True);
        }
        [Test]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert 
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse()
        {
            // Arrange
            var reservation = new Reservation { MadeBy = new User() };

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });

            // Assert
            Assert.That(result, Is.False);
        }
    }
}
