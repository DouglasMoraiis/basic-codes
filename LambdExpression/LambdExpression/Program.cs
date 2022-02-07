using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingLambdExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sum = (number1, number2) => number1 + number2;

            Console.WriteLine(sum(5, 7));
        }
    }
}
