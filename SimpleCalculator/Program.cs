using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, num2;
            int choice;

            Console.WriteLine("Please enter the first number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your choice");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        double addition = num + num2;
                        Console.WriteLine("Your answer is" + addition);
                        break;
                    }
                case 2:
                    {
                        double subtraction = num - num2;
                        Console.WriteLine("Your answer is" + subtraction);
                        break;
                    }
                case 3:
                    {
                        double multiply = num * num2;
                        Console.WriteLine("Your answer is" + multiply);
                        break;
                    }
                case 4:
                    {
                        double division = num / num2;
                        Console.WriteLine("Your answer is" + division);
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
