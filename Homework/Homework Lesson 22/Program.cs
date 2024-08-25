using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int Lenght;
                string type, Symbol;
                try
                {
                    Console.Write("Высота треугольника (l) = ");
                    Lenght = int.Parse(Console.ReadLine());
                    Console.Write("Выберите символ = ");
                    Symbol = Console.ReadLine();
                    Console.Write("Тип треугольника (от 1 до 4)= ");
                    type = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Неверно указаны значения!");
                    continue;
                }
                switch (type)
                {
                    case "1":
                        {
                            for (int i = 0; i < Lenght; i++)
                            {
                                for (int l = i; l >= 0; l--)
                                {
                                    Console.Write(Symbol);
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case "2":
                        {
                            for (int i = Lenght; i >0; i--)
                            {
                                for (int l = i;l > 0; l--)
                                {
                                    Console.Write(Symbol);
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case "3":
                        {
                            for (int i = 0; i < Lenght; i++)
                            {
                                for (int k = Lenght - i - 1; k>0; k--)
                                    {
                                        Console.Write(" ");
                                    }
                                for (int l = i; l >= 0; l--)
                                {
                                    Console.Write(Symbol);
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case "4":
                        {
                            for (int i = Lenght; i > 0; i--)
                            {
                                for (int k = Lenght - i; k > 0; k--)
                                {
                                    Console.Write(" ");
                                }
                                for (int l = i; l > 0; l--)
                                {
                                    Console.Write(Symbol);
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Ошибка! Выбран неверный тип.");
                        continue;

                }
                Console.ReadLine ();
            }
        }
    }
}
