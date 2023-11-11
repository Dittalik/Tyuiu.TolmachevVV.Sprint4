using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TolmachevVV.Sprint4.Task7.V11.Lib;

namespace Tyuiu.TolmachevVV.Sprint4.Task7.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service1 = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Толмачев. В. В. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #4                                                                *");
            Console.WriteLine("*Задание #7                                                               *");
            Console.WriteLine("*Вариант #11                                                              *");
            Console.WriteLine("*Выполнил: Толмачев Виталий Владимирович | ПКТб 23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("56789012                                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Матрица:");
            string str = "56789012";
            int[,] matrix = new int[4, 2];
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(str[count]);
                    if (j == 1)
                    {
                        Console.Write($"{str[count]} \n");
                    }
                    else
                    {
                        Console.Write($"{str[count]} \t");
                    }
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных чисел в матрице: " + service1.Calculate(4, 2, str));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
