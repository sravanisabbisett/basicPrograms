using System;

namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BasicProgram conversion = new BasicProgram();
            collections collections = new collections();
            int result = conversion.convertingToInt(5.6783);
            Console.WriteLine("Conversion of double to int::" + result);
            int addResult = conversion.addition(5, 4);
            Console.WriteLine("addtion of two numbers::" + addResult);
            int maxResult = conversion.findMax(6, 7);
            Console.WriteLine("Maximum of Two Numbers::" + maxResult);
            int factorial = conversion.factorial(6);
            Console.WriteLine("factorial of number is::" + factorial);
            conversion.generateRandom();
            conversion.convertStringToLower();
            conversion.sumOfTheDigits();
            conversion.switchDemo();
            collections.ListDemo();
            Console.ReadKey();
        }
    }
}
