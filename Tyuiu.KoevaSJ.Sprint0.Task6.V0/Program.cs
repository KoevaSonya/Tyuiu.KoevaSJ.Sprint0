﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoevaSJ.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KoevaSJ.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5, };

            //Пример циклической структуры находится в библиотеке классов в методе AdditionArray
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));

            Console.WriteLine("Разность элементов массива = " + DataService.SubstractionArray(numsArray));

            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
