﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class VD1
    {
        static void Calculate(ref int numValueOne, ref int numValueTwo)
        {
            numValueOne = numValueOne * 2;
            numValueTwo = numValueTwo / 2;
        }
        static void Main1(string[] args)
        {
            int numOne = 10;
            int numTwo = 20;
            Console.WriteLine("Value of Num1 and Num2 before calling method" + numOne + "," + numTwo);
            Calculate(ref numOne, ref numTwo);
            Console.WriteLine("Value of Num1 and Num2 after calling method" + numOne + "," + numTwo);
            Console.ReadKey();
        }
    }
}
