using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstApplication
{
    class BasicProgram
    {
        public int convertingToInt(double d)
        {
            int i;
            i = (int)d;
            return i;
        }

        public int addition(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int findMax(int a, int b)
        {
            return Math.Max(a, b);
        }

        public int factorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        public void generateRandom()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 1);
            if (randomNumber == 0)
                Console.WriteLine("coin flips head");
            else
                Console.WriteLine("coin flips tail");
        }

        public void convertStringToLower()
        {
            String name = "sravani";
            Console.WriteLine("convert string to upper::" + name.ToUpper());
        }
        public void sumOfTheDigits()
        {
            Console.WriteLine("Enter your number for sum of the digits");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine("sum of the digits of is:" + sum);
        }
        public void switchDemo()
        {
            Console.WriteLine("Enter your number");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                default:
                    Console.WriteLine("Please enter valid number");
                    break;
            }
        }
        public int findMin(int a,int b)
        {
            return Math.Min(a, b);
        }
    }
}
