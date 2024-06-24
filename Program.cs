using System;

namespace BasicCalculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string choice;
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Result: " + add());
                        break;
                    case "2":
                        Console.WriteLine("Result: " + subtract());
                        break;
                    case "3":
                        Console.WriteLine("Result: " + multiply());
                        break;
                    case "4":
                        Console.WriteLine("Result: " + divide());
                        break;
                    case "5":
                        Console.WriteLine("Result: " + modulo());
                        break;
                    case "6":
                        Console.WriteLine("Result: " + power());
                        break;
                    case "7":
                        Console.WriteLine("Result: " + square());
                        break;
                    case "8":
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please input [1-8]");
                        break;
                }
            } while (choice != "8");
        }

        public static string Menu()
        {
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Modulo");
            Console.WriteLine("6. Power");
            Console.WriteLine("7. Square");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");
            return Console.ReadLine();
        }

        static int add()
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            return a + b;
        }

        static int subtract()
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            return a - b;
        }

        static int multiply()
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            return a * b;
        }

        static int divide()
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            return a / b;
        }

        static int modulo()
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            return a % b;
        }

        static int power()
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            return (int) Math.Pow(a, b);
        }

        static int square()
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            return a * a;
        }
    }
}