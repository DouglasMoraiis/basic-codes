using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Jander";
            cookies["email"] = "jander@gmail.com";
            cookies["phone"] = "8823232323";

            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine($"{item.Key}: {item.Value}.");
            }
        }
    }
}
