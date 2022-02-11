using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2020, 12, 14, 20, 1, 15);
            Console.WriteLine(dateTime.ElapsedTime());
        }
    }
}
