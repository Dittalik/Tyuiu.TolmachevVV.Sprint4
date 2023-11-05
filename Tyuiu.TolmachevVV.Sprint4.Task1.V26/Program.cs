using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint4.Task1.V26.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("Задайте количество элементов массива                                      *");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите значение " + i + " элемента массива");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x < 0 || x > 8)
                {
                    Console.WriteLine("Значение должно быть не менее 0 и не более 8, введите значение еще раз");
                    x = Convert.ToInt32(Console.ReadLine());
                }
                array[i] = x;

            }
            Console.WriteLine("Задан массив: ");
            array.ToList().ForEach(y => Console.Write(y.ToString() + "\t"));
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
