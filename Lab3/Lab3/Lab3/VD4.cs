using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class VD4
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Square of interger value " + Square(5));
            Console.WriteLine("Square of float value " + Square(2.5F));
            Console.ReadKey();
        }


        static int Square(int num)
        {
            return num * num;
        }
        static float Square(float num)
        {
            return num * num;
        }
    }
}
