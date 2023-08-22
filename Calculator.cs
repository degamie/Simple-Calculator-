using System;
namespace Calculator
{
    class Calculator_program
    {
        static void Main(String[] args)
        {
            //variable declaration & initialization

            double num1 = 0, num2 = 0, result = 0;
            Console.WriteLine("Welcome to Calcultor!");

            //input
            Console.WriteLine("Enter Num1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Num2");
            num2 = Convert.ToDouble(Console.ReadLine());

            //Option Selection
            Console.WriteLine("Select an Option\n");
            Console.WriteLine("\t+: Addition:");
            Console.WriteLine("\t-: Subtraction:");
            Console.WriteLine("\t*: Multiplication:");
            Console.WriteLine("\t/: Division:");
            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    //Console.Write($"result:{num1}+{num2}="+result);
                    Console.WriteLine($"result:" + result);
                    break;
                case "-":
                    result = num1 - num2;
                    //Console.Write($"result:{num1}-{num2}"+result);
                    Console.WriteLine($"result:" + result);
                    break;
                case "*":
                    result = num1 * num2;
                    //Console.Write($"result:{num1} + {num2}",+result);
                    Console.WriteLine($"result:" + result);
                    break;
                case "/":
                    result = num1 / num2;
                    //Console.Write($"result:{num1}/{num2}",+result);
                    Console.WriteLine($"result:" + result);
                    break;
                default:
                    Console.Write("Invalid Option:\n");
                    break;
                    //Console.ReadKey();

            }
        }
      
    }
}
