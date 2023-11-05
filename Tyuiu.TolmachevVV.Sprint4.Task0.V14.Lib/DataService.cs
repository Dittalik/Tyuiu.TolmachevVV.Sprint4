using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TolmachevVV.Sprint4.Task0.V14.Lib
{
    public class DataService : ISprint4Task0V14
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i++, i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
