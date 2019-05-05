using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collattz_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            var numStr = Console.ReadLine();

            var num = NumConverter.Convert(numStr);
            if (num == -1) return;

            var calculator = new CollatzProblemCalculator(num);
            
            Console.WriteLine(calculator.Calculate());
            Console.ReadLine();
        }
    }
}
