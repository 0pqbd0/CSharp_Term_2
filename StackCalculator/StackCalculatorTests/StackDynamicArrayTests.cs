namespace StackImplementation.Tests
{
    [TestClass()]
    public class StackDynamicArrayTests
    {
        private StackDynamicArray stack;

        [TestInitialize]
        public void Initialize()
        {
            stack = new StackDynamicArray();
        }

        [TestMethod()]
        public void PushTest()
        {
            Assert.IsTrue(stack.IsEmpty());
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
        }

        [TestMethod()]
        public void PopTest()
        {
            stack.Push(1);
            var result = stack.Pop();
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void PopWithTwoElementsTest()
        {
            stack.Push(1);
            stack.Push(3);
            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }

        [TestMethod()]
        public void PopWithOutPushTest()
        {
            var ex = Assert.ThrowsException<InvalidOperationException>(() => stack.Pop());
            Assert.AreEqual(ex.Message, "Can't pop from empty stack!");

        }

        [TestMethod()]
        public void IsEmptyTest()
        {
            Assert.IsTrue(stack.IsEmpty());
        }
    }
}