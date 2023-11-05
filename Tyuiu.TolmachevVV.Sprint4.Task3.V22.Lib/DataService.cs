using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TolmachevVV.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int x = int.MinValue;
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                if (array[0, i] > x)
                {
                    x = array[0, i];
                }
            }
            return x;
        }
    }
}
