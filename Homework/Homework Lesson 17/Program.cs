using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int count, count2, limit, sumodd = 0, sumeven = 0;
                uint oddMumbersCount = 0, evenMumbersCount = 0;
                try
                {
                    Console.WriteLine("Укажите диапазон чисел.");
                    Console.WriteLine("Нижняя граница ");                    
                    count2 = count = int.Parse(Console.ReadLine());
                    Console.WriteLine("Верхняя граница ");
                    limit = int.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Введён некорректный диапозон чисел");
                    Console.WriteLine("Нажмите Enter чтобы продолжить");
                    Console.ReadLine();
                    continue;
                }
                if (count <= limit)
                {
                    while (count <= limit)
                    {
                        if (count % 2 == 0)
                        {
                            oddMumbersCount++;
                            sumodd = sumodd + count;
                        }
                        else
                        {
                            evenMumbersCount++;
                            sumeven = sumeven + count;
                        }
                        count++;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Нижняя граница диапазона не может быть больше верхней.");
                    Console.WriteLine("Нажмите Enter чтобы продолжить");
                    Console.ReadLine();
                    continue;
                }
                Console.WriteLine("В диапазоне чисел [" + count2 + ";" + limit + "] находится " + oddMumbersCount + " чётных и " + evenMumbersCount + " нечётных чисел");
                Console.WriteLine("Сумма всех чётных чисел = "+ sumodd);
                Console.WriteLine("Сумма всех нечётных чисел = "+ sumeven);
                Console.WriteLine("Сумма чётных и нечётных чисел = " + (sumodd + sumeven));
            }
        } 
    }
}
