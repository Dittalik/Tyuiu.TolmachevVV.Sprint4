using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint4.Task4.V6.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task4.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #4                                                                *");
            Console.WriteLine("*Задание #2                                                               *");
            Console.WriteLine("*Вариант #2                                                               *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Задайте количество строк и столбцов в массиве                             *");
            int[,] array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine($"Задайте i-{i}, j-{j}, элемент массива");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Массив:");
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == array.GetLength(1) - 1)
                    {
                        Console.Write($"{array[i, j]} \n");
                    }
                    else
                    {
                        Console.Write($"{array[i, j]} \t");
                    }
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < service1.Calculate(array).GetLength(0); i++)
            {
                for (int j = 0; j < service1.Calculate(array).GetLength(1); j++)
                {
                    if (j == service1.Calculate(array).GetLength(1) - 1)
                    {
                        Console.Write($"{service1.Calculate(array)[i, j]} \n");
                    }
                    else
                    {
                        Console.Write($"{service1.Calculate(array)[i, j]} \t");
                    }

                }
            }
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
