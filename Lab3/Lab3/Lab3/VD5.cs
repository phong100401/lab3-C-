using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class VD5
    {
        double _length;
        double _breadth;

        public double Area(double _length, double _breadth)
        {
            this._breadth = _breadth;
            this._length = _length;
            return _length * _breadth;
        }
        static void Main(string[] args)
        {
            VD5 objDes = new VD5();
            Console.WriteLine("Area of rectangle = " + objDes.Area(10.5, 12.5));
            Console.ReadKey();
        }
    }
}
