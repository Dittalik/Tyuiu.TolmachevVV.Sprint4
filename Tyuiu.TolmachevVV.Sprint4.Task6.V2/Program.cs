using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint4.Task6.V2.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #4                                                                *");
            Console.WriteLine("*Задание #6                                                               *");
            Console.WriteLine("*Вариант #2                                                               *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Белый, Черный, Зеленый, Синий, Красный, Желтый, Фиолетовый                *");
            string[] array = service1.Calculate(new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" });
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            foreach(string item in array)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
