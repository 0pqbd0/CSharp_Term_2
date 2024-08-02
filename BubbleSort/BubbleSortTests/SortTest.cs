using Sorting;


namespace SortingTests
{
    [TestClass()]
    public class SortTest
    {
        [TestMethod()]
        public void BubbleSortTestWithNegativeNumbers()
        {
            int[] arrayToSort = { 7, 8, 5, 4, 100, 11, 3, 2, 1, -5, -17 };
            int[] sortedArray = { -17, -5, 1, 2, 3, 4, 5, 7, 8, 11, 100 };
            Sort.BubbleSort(arrayToSort);
            CollectionAssert.AreEqual(arrayToSort, sortedArray);
        }

        [TestMethod()]
        public void BubbleSortTestWithAlreadySortedArray()
        {
            int[] arrayToSort = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Sort.BubbleSort(arrayToSort);
            CollectionAssert.AreEqual(arrayToSort, sortedArray);
        }

        [TestMethod()]
        public void BubbleSortTestWithEmptyArray()
        {
            int[] arrayToSort = new int[0];
            int[] sortedArray = {  };
            Sort.BubbleSort(arrayToSort);
            CollectionAssert.AreEqual(arrayToSort, sortedArray);
        }
    }
}