using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetsAndSets
{
    public class Person
    {
        private String _name;

        // PRIMEIRA FORMA DE CRIAR GETS E SETS
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }

        // SEGUNDA FORMA DE CRIAR GETS E SETS
        public string Name
        {
           get { return _name; }
           set { _name = value; }
        }

        // TERCEIRA FORMA DE USAR GETS E SETS
        public string MyName { get; set; } 
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            
            //PRIMEIRA FORMA DE USAR OS GETS E SETS
            person1.SetName("Jander");
            var name = person1.GetName();
            Console.WriteLine(name);

            //SEGUNDA FORMA DE USAR OS GETS E SETS
            person1.Name = "Douglas";
            Console.WriteLine(person1.Name);

            //TERCEIRA FORMA DE USAR OS GETS E SETS
            person1.MyName = "Morais";
            Console.WriteLine(person1.MyName);
        }
    }
}
