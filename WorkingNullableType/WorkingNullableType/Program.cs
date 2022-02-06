using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingNullableType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2020, 1, 26);
            DateTime date2 = date.GetValueOrDefault();
            Console.WriteLine(date2);

            // Operador de coalescencia nulo (??)
            DateTime niver = date ?? DateTime.Today;

            // Se 'date' for null então 'niver' recebera DateTime.Today
        }
    }
}
