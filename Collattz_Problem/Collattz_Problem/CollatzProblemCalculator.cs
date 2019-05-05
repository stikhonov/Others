using System;
using System.Text;

namespace Collattz_Problem
{
    public class CollatzProblemCalculator
    {
        private readonly long _num;
        public CollatzProblemCalculator(long num)
        {
            _num = num;
        }

        public string Calculate()
        {
            var num = _num;
            var result = new StringBuilder();
            while (num != 1)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = num * 3 + 1;
                }

                result.Append($"{num}, ");
            }

            return result.ToString();
        }

    }
}