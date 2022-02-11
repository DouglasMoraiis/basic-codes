using Delegates.Services;
using System;

namespace Delegates
{
    class Program
    {
        /*
         * São usados para passar metodos como parametros de outros métodos. Semelhando ao que fazemos em Javascript quando queremos passar uma função de callback para outra função.
        */
        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            Console.WriteLine(op(a, b));
        }
    }
}
