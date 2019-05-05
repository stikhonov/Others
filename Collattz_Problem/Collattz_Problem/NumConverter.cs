using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collattz_Problem
{
    static class NumConverter
    {
        public static long Convert(string str)
        {
            if (long.TryParse(str, out var num)) return num;

            Console.WriteLine("It's not a number!");
            return -1;

        }
    }
}
