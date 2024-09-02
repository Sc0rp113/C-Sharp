using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a, b;
                string operation;
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
                switch (operation)
                {
                    case "+":
                        Console.WriteLine(a + "+" + b + "=" + (a+b));
                        break;
                    case "-":
                        Console.WriteLine(a + "-" + b + "=" + (a-b));
                        break;
                    case "*":
                        Console.WriteLine(a + "*" + b + "=" + (a*b));
                        break;
                    case ":":
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Деление на 0 запрещено!");
                        }
                        else
                        {
                            Console.WriteLine(a + ":" + b + "=" + (a/b));
                        }
                        break;
                    default:
                        Console.WriteLine("Введен некорректный оператор - " + operation);
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
