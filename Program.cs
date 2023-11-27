using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22 
{ 

    public class Assignment22
    {
        public delegate int ArithmeticOperation(int num1, int num2);

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            ArithmeticOperation addition = new ArithmeticOperation(Add);
            ArithmeticOperation subtraction = new ArithmeticOperation(Subtract);
            ArithmeticOperation multiplication = new ArithmeticOperation(Multiply);
            ArithmeticOperation division = new ArithmeticOperation(Divide);

            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an arithmetic operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            string operation = Console.ReadLine();

            ArithmeticOperation arithmeticOperation = null;

            switch (operation)
            {
                case "1":
                    arithmeticOperation = addition;
                    break;
                case "2":
                    arithmeticOperation = subtraction;
                    break;
                case "3":
                    arithmeticOperation = multiplication;
                    break;
                case "4":
                    arithmeticOperation = division;
                    break;
                default:
                    Console.WriteLine("Invalid operation choice");
                    break;
            }

            if (arithmeticOperation != null)
            {
                int result = arithmeticOperation(num1, num2);
                Console.WriteLine($"The result of the operation is: {result}");
            }
            Console.ReadKey();
        }
    }
}

