using System;
using StackPostfixCalculator;
using StackImplementation;
class Program
{
    static void Main()
    {
        bool choosing = true;

        IStack stack = new StackDynamicArray();

        while (choosing)
        {
            Console.WriteLine("It's stack calculator!");
            Console.WriteLine("Select the stack implementation");
            Console.WriteLine("""

            1 - dynamic array 
            2 - linked list

            """);

            var stackImplementation = Console.ReadLine();


            switch (stackImplementation)
            {
                case "1":
                    choosing = false;
                    break;

                case "2":
                    choosing = false;
                    stack = new StackLinkedList();
                    break;

                default:
                    Console.WriteLine("Wrong input! Try again.");
                    break;
            }
        }

        bool proccesing = true;

        while (proccesing)
            {

                Console.Write("Enter you expression in postfix style: ");
                var postfixExpression = Console.ReadLine();

                try
                {
                    var result = StackCalculator.Calculating(postfixExpression, stack);
                    Console.WriteLine($"Result: {result}");
                    proccesing = false;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
    }
}
