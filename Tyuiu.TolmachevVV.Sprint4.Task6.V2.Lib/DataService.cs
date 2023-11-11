﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.TolmachevVV.Sprint4.Task6.V2.Lib
{
    public class DataService : ISprint4Task6V2
    {
        public string[] Calculate(string[] array)
        {
            string[] answ = Array.FindAll(array, item => item.Length > 5);
            return answ;
        }
    }
}
