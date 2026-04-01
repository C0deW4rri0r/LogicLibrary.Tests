using NUnit.Framework;
using LogicLibrary;

namespace LogicLibrary.Tests
{
    public class LogicOperationsTests
    {
        [Test]
        public void And_TrueAndTrue_ReturnsTrue()
        {
            var result = LogicOperations.And(true, true);
            Assert.That(result, Is.True);
        }

        [Test]
        public void And_TrueAndFalse_ReturnsFalse()
        {
            var result = LogicOperations.And(true, false);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Or_FalseOrTrue_ReturnsTrue()
        {
            var result = LogicOperations.Or(false, true);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Or_FalseOrFalse_ReturnsFalse()
        {
            var result = LogicOperations.Or(false, false);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Not_NotTrue_ReturnsFalse()
        {
            var result = LogicOperations.Not(true);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Not_NotFalse_ReturnsTrue()
        {
            var result = LogicOperations.Not(false);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Xor_TrueXorTrue_ReturnsFalse()
        {
            var result = LogicOperations.Xor(true, true);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Xor_TrueXorFalse_ReturnsTrue()
        {
            var result = LogicOperations.Xor(true, false);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Evaluate_ValidExpression_ReturnsCorrectResult()
        {
            var result = LogicOperations.Evaluate("true AND false");
            Assert.That(result, Is.False);
        }

        [Test]
        public void Evaluate_EmptyString_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => LogicOperations.Evaluate(""));
        }

        [Test]
        public void Evaluate_InvalidOperator_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => LogicOperations.Evaluate("true AAA false"));
        }
    }
}
