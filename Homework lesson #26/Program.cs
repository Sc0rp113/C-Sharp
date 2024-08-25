using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_lesson__26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                uint elemets_count;
                try
                {
                    Console.Write("Введите кол-во элементов массива - ");
                    elemets_count = uint.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверно указано кол-во элементов массива!");
                    continue;
                }
                int[] array = new int[elemets_count];
                try
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.Write("Введите " + (i + 1) + " значение элемента массива - ");
                        array[i] = int.Parse(Console.ReadLine());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверно указано значение!");
                    continue;
                }
                Console.WriteLine("Массив введён. Выберете действие которое хотите выполнить.");
                while (true)
                {
                    Console.WriteLine("1)Вывести массив в обратном порядке");
                    Console.WriteLine("2)Найти сумму четных чисел в массиве");
                    Console.WriteLine("3)Найти наименьшее число в массиве");
                    Console.WriteLine("4)Выйти.");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Массив в обратном порядке: ");
                            for (int i = array.Length - 1; i >= 0; i--)
                            {
                                Console.Write(array[i] + " ");
                            }
                            Console.WriteLine();
                            break;
                        case "2":
                            int k = 0;
                            for (int i = 0; i < array.Length; i++)
                            {
                                if (array[i] % 2 == 0)
                                    k += array[i];
                            }
                            Console.WriteLine("Сумма всех чётных чисел массива = " + k);
                            break;
                        case "3":
                            int l = array[0];
                            for (int i = 1; i < array.Length; i++)
                            {
                                if (l > array[i])
                                {
                                    l = array[i];
                                }
                            }
                            Console.WriteLine("Наименьшее число массива - " + l);
                            break;
                        case "4":
                        case "close":
                        case "exit":
                            option = "exit";
                            break;
                        default: Console.WriteLine("Дествия " + option + " не существует.");
                            continue;

                    }
                    if (option == "exit")
                        break;
                }
                break;
            }
        }
    }
}
