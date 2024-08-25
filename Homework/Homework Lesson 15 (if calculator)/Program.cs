using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lesson_15__if_calculator_
{
    internal class Program
    {
        static void Main(string[] args)
        {while(true) 
            {
                double a, b;
                string operation;
                Console.WriteLine("Введите первое число ");
                bool suc1 = double.TryParse(Console.ReadLine(), out a);
                try
                {
                    Console.WriteLine("Введите первое число ");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число ");
                    b = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Введено неверное значение!");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("Введите символ операции ");
                operation = Console.ReadLine();
                if (operation == "+")
                {
                    Console.WriteLine(a + "+" + b + "=" + (a + b));
                }
                else if (operation == "-")
                {
                    Console.WriteLine(a + "-" + b + "=" + (a - b));
                }
                else if (operation == "*")
                {
                    Console.WriteLine(a + "*" + b + "=" + (a * b));
                }
                else if ((operation == "/") || (operation == ":"))
                {
                    switch (b)
                    {
                        case 0:
                            Console.WriteLine("Деление на 0 запрещено!");
                            break;
                        default:
                            Console.WriteLine(a + ":" + b + "=" + (a - b));
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Введен некорректный оператор - " + operation);
                }
                Console.ReadLine();
            }
        }
    }
}
