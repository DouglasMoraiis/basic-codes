using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
       
            try
            {
                num1 = 5;
                num2 = 2;
                result = num1 / num2;
                throw new Exception("Uma excecao personalizada foi disparada!");
           
            }
            catch (Exception e)
            {
                Console.WriteLine("Sorry, an unexpected error occurred.");
                Console.WriteLine("Error: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Finally executado!");
            }

            Console.WriteLine("#########");
        }
    }
}
