using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingPolymorphism
{
    // DECLARAÇÃO DE UMA CLASSE ABSTRATA E SEUS MÉTODOS
    public abstract class Shape
    {
        public abstract void Draw();
    }

    //Circle HERDANDO DA CLASSE ABSTRATA Shape
    public class Circle : Shape
    {
        public override void Draw()
        {
            // IMPLEMENTATION
        }
        public virtual void View()
        {
            Console.WriteLine("View of Class Circle");
        }
    }

    //Line HERDANDO DA CLASSE CONCRETA Circle
    public class Line : Circle
    {
        // SOBRESCRITA DO METODO View USANDO O POLIMORFISMO
        public override void View()
        {
            Console.WriteLine("View of Class Line");
        }

        public override void Draw()
        {
            Console.WriteLine("Implementaçao do Draw em Line!");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var myCircle = new Circle();
            myCircle.View();

            var myLine = new Line();
            myLine.View();
            myLine.Draw();
        }
    }
}
