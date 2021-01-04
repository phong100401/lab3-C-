using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class VD2
    {
        static void depreciation(out int val)
        {
            val = 20000;
            int dep = val * 5 / 100;
            int amt = val - dep;
            Console.WriteLine("Depreciation Amount : " + dep);
            Console.WriteLine("Reduced value after deppreciation : " + amt);

        }
        static void Main2(string[] args)
        {
            int value;
            depreciation(out value);
            Console.ReadKey();
        }
    }
}
