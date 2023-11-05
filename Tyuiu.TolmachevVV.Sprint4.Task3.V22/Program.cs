using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint4.Task3.V22.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #4                                                                *");
            Console.WriteLine("*Задание #3                                                               *");
            Console.WriteLine("*Вариант #22                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("{ 4, 4, 7, 8, 9 }                                                         *");
            Console.WriteLine("{ 9, 5, 9, 7, 8 }                                                         *");
            Console.WriteLine("{ 7, 4, 9, 4, 6 }                                                         *");
            Console.WriteLine("{ 4, 4, 7, 4, 4 }                                                         *");
            Console.WriteLine("{ 4, 5, 8, 6, 7 }                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(service1.Calculate(new int[,] { { 4, 4, 7, 8, 9 },
                                                              { 9, 5, 9, 7, 8 },
                                                              { 7, 4, 9, 4, 6 },
                                                              { 4, 4, 7, 4, 4 },
                                                              { 4, 5, 8, 6, 7 } }));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
