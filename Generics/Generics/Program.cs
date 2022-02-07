using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingGenerics
{
    internal class Program
    {
        public class GenericList<T>
        {
            public List<T> list;

            public void Add(T value)
            {
                this.list.Add(value);    
            }
            public T this[int index]
            {
                get { return list[index]; }
            }
        }

        static void Main(string[] args)         
        {
            var numbers = new GenericList<int>();
            numbers.Add(1);
            Console.WriteLine(numbers[0]);

        }
    }
}
