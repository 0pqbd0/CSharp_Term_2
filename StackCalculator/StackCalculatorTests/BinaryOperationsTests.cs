namespace StackPostfixCalculator.Tests
{
    [TestClass()]
    public class BinaryOperationsTests
    {
        [TestMethod()]
        public void CalculateOperationWithTwoIntAdd()
        {
            double firstOperand = 7;
            double secondOperand = 5;
            string operand = "+";
            var result = BinaryOperations.CalculateOperation(firstOperand, secondOperand, operand);
            Assert.AreEqual(12, result);
        }

        [TestMethod()]
        public void CalculateOperationWithTwoDoubleAdd()
        {
            double firstOperand = 7.5;
            double secondOperand = 5.3;
            string operand = "+";
            var result = BinaryOperations.CalculateOperation(firstOperand, secondOperand, operand);
            Assert.AreEqual(12.8, result);
        }

        [TestMethod()]
        public void CalculateOperationWithTwoIntSub()
        {
            double firstOperand = 7;
            double secondOperand = 5;
            string operand = "-";
            var result = BinaryOperations.CalculateOperation(firstOperand, secondOperand, operand);
            Assert.AreEqual(-2, result);
        }

        [TestMethod()]
        public void CalculateOperationWithTwoDoubleSub()
        {
            double firstOperand = 7.5;
            double secondOperand = 5.3;
            string operand = "-";
            var result = BinaryOperations.CalculateOperation(firstOperand, secondOperand, operand);
            Assert.AreEqual(-2.2, result);
        }

        [TestMethod()]
        public void CalculateOperationWithTwoIntMul()
        {
            double firstOperand = 7;
            double secondOperand = 5;
            string operand = "*";
            var result = BinaryOperations.CalculateOperation(firstOperand, secondOperand, operand);
            Assert.AreEqual(35, result);
        }

        [TestMethod()]
        public void CalculateOperationWithTwoDoubleMul()
        {
            double firstOperand = 7.5;
            double secondOperand = 5.3;
            string operand = "*";
            var result = BinaryOperations.CalculateOperation(firstOperand, secondOperand, operand);
            Assert.AreEqual(39.75, result, 0.00000001);
        }

        [TestMethod()]
        public void CalculateOperationWithTwoIntDiv()
        {
            double firstOperand = 6;
            double secondOperand = 12;
            string operand = "/";
            var result = BinaryOperations.CalculateOperation(firstOperand, secondOperand, operand);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void CalculateOperationWithTwoDoubleDiv()
        {
            double firstOperand = 1.5;
            double secondOperand = 5.55;
            string operand = "/";
            var result = BinaryOperations.CalculateOperation(firstOperand, secondOperand, operand);
            Assert.AreEqual(3.7, result, 0.00000001);
        }


        [TestMethod()]
        public void CalculateOperationDivisionByZero()
        {
            double firstOperand = 0;
            double secondOperand = 5;
            string operand = "/";
            var ex = Assert.ThrowsException<DivideByZeroException>(() => BinaryOperations.CalculateOperation(firstOperand, secondOperand, operand));
            Assert.AreEqual(ex.Message, "The second operand is zero. Can't be devided by zero!");
        }

        [TestMethod()]
        public void CalculateOperationWithIncorrectCharacter()
        {
            double firstOperand = 5;
            double secondOperand = 15;
            string operand = "%";
            var ex = Assert.ThrowsException<InvalidOperationException>(() => BinaryOperations.CalculateOperation(firstOperand, secondOperand, operand));
            Assert.AreEqual(ex.Message, "Incorrect character!");
        }
    }
}

