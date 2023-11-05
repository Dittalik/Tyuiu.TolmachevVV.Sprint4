using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint4.Task0.V14.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task0.V14
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
            Console.WriteLine("{ 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 }                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(service1.GetSumOddArrEl(new int[] { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 }));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
