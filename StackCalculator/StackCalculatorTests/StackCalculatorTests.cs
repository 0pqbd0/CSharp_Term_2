using StackImplementation;

namespace StackPostfixCalculator.Tests
{
    [TestClass()]
    public class StackCalculatorTests
    {
        private StackDynamicArray stackD;
        private StackLinkedList stackL;

        [TestInitialize]
        public void Initialize()
        {
            stackD = new StackDynamicArray();
            stackL = new StackLinkedList();
        }

        [TestMethod()]
        public void CalculatingWithNullExpressionUsingDynamicArray()
        {
            string? postfixExpression = null;
            var ex = Assert.ThrowsException<ArgumentNullException>(() => StackCalculator.Calculating(postfixExpression, stackD));
            Assert.AreEqual(ex.Message, "Value cannot be null. (Parameter 'Expression can`t be null!')");
        }

        [TestMethod()]
        public void CalculatingWithNullExpressionUsingLinkedList()
        {
            string? postfixExpression = null;
            var ex = Assert.ThrowsException<ArgumentNullException>(() => StackCalculator.Calculating(postfixExpression, stackL));
            Assert.AreEqual(ex.Message, "Value cannot be null. (Parameter 'Expression can`t be null!')");
        }

        [TestMethod()]
        public void CalculatingWithEmptyExpressionUsingDynamicArray()
        {
            string postfixExpression = "";
            var ex = Assert.ThrowsException<ArgumentException>(() => StackCalculator.Calculating(postfixExpression, stackD));
            Assert.AreEqual(ex.Message, "Expression can`t be empty!");
        }

        [TestMethod()]
        public void CalculatingWithEmptyExpressionUsingLinkedList()
        {
            string postfixExpression = "";
            var ex = Assert.ThrowsException<ArgumentException>(() => StackCalculator.Calculating(postfixExpression, stackL));
            Assert.AreEqual(ex.Message, "Expression can`t be empty!");
        }

        [TestMethod()]
        public void CalculatingWithCorrectExxpressionUsingDynamicArray()
        {
            string postfixExpression = "1 2 +";
            var result = StackCalculator.Calculating(postfixExpression, stackD);
            Assert.AreEqual(3, result);

        }

        [TestMethod()]
        public void CalculatingWithCorrectExxpressionUsingLinkedList()
        {
            string postfixExpression = "1 2 +";
            var result = StackCalculator.Calculating(postfixExpression, stackL);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CalculatingWithIncorrectExxpressionDynamicArray()
        {
            string postfixExpression = "1 2 3 *";
            var ex = Assert.ThrowsException<ArgumentException>(() => StackCalculator.Calculating(postfixExpression, stackL));
            Assert.AreEqual(ex.Message, "Incorrect expression in the postfix entry!");
        }

        [TestMethod()]
        public void CalculatingWithIncorrectExxpressionUsingLinkedList()
        {
            string postfixExpression = "1 2 3 *";
            var ex = Assert.ThrowsException<ArgumentException>(() => StackCalculator.Calculating(postfixExpression, stackD));
            Assert.AreEqual(ex.Message, "Incorrect expression in the postfix entry!");
        }
    }
}
