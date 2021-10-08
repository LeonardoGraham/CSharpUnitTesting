using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<string>();
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_ArgIsNull_ThrowsArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }
        [Test]
        public void Push_ValidArg_AddTheObjectToTheStack()
        {
            _stack.Push("a");

            Assert.That(_stack.Count, Is.EqualTo(1));
        }
                

        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void Pop_StackWithObjects_ReturnObjectOnTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo("c"));
        }
        [Test]
        public void Pop_StackWithObjects_RemoveObjectOnTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            _stack.Pop();

            Assert.That(_stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }
        [Test]
        public void Peek_StackWithObjects_ReturnObjectOnTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            var result = _stack.Peek();

            Assert.That(result, Is.EqualTo("c"));
        }
        [Test]
        public void Peek_StackWithObjects_RemoveObjectOnTop()
        {
            _stack.Push("a");
            _stack.Push("b");
            _stack.Push("c");

            _stack.Peek();

            Assert.That(_stack.Count, Is.EqualTo(3));
        }
    }
}
