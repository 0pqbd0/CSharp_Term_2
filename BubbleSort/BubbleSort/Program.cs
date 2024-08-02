using Sorting;
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");

        int arraySize;

        while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 0)
        {
            Console.WriteLine("Wrong size. Must be a positive number!");
            Console.Write("Enter array size: ");
        }

        int[] numArray = new int[arraySize];

        Console.WriteLine("Enter array elements one by one:");

        for (int i = 0; i < arraySize ; ++i)
        {
            while (!int.TryParse(Console.ReadLine(), out numArray[i]))
            {
                Console.WriteLine("Wrong value!");
                Console.Write("Enter another value: ");
            }
        }

        Sort.BubbleSort(numArray);

        for (int i = 0; i < numArray.Length; ++i)
        {
            Console.Write(numArray[i] + " ");
        }
    }
}
