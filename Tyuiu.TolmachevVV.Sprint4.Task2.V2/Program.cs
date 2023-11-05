using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint4.Task2.V2.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task2.V2
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
            Console.WriteLine("*Задание #0                                                               *");
            Console.WriteLine("*Вариант #14                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Задайте количество элементов массива");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Массив:                                                                   *");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(1, 8);
            }
            array.ToList().ForEach(i => Console.Write(i.ToString() + "\t"));
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(service1.Calculate(array));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
