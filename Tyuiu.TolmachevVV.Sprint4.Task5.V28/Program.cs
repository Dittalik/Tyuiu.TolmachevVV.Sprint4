using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint4.Task5.V28.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task5.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            DataService service1 = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #4                                                                *");
            Console.WriteLine("*Задание #5                                                               *");
            Console.WriteLine("*Вариант #28                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Задайте количество элементов массива");
            int[,] array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Массив:                                                                   *");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rng.Next(-6, 3);
                    if (j == array.GetLength(1) - 1)
                    {
                        Console.Write($"{array[i, j]}\n");
                    }
                    else
                    {
                        Console.Write($"{array[i, j]}\t");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] x = service1.Calculate(array);
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    if (j == x.GetLength(1) - 1)
                    {
                        Console.Write($"{x[i, j]}\n");
                    }
                    else
                    {
                        Console.Write($"{x[i, j]}\t");
                    }
                }
            }
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
