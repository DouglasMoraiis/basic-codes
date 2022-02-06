using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DATETIME            
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);


/*            Console.WriteLine(now);
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
*/
            // TIMESPAN
            var timeSpan = new TimeSpan(1, 5, 3);
            var timeSpan1 = TimeSpan.FromDays(1);
/*
            Console.WriteLine(timeSpan.Hours);
            Console.WriteLine(timeSpan.Minutes);
            Console.WriteLine(timeSpan.Seconds);
            Console.WriteLine(timeSpan1.TotalHours);
*/
            // OPERATIONS TIME
            var start = DateTime.Now;
            var end = start.AddMinutes(5);
            var duration = end - start;
            /*
                        Console.WriteLine(duration);
                        */

            float price = 20232.20f;
            Console.WriteLine(price.ToString("C2"));


        }
    }
}
