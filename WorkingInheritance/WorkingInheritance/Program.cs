using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingInheritance
{
    public class Vehicle
    {
        public string name;
        public float value;

        public Vehicle(string name, float value)
        {
            this.name = name;
            this.value = value;
        }

        public void Move()
        {
            Console.WriteLine("The Vehicle it's in motion");
        }
    }

    public class Car : Vehicle
    {
        public int seats;
        private bool seatBelt;

        public Car(string name, float value, int seats) : base(name, value) {
            this.seats = seats;
            seatBelt = false;
        }

        public void PutSeatBelt()
        {
            SeatBelt = true;
            Console.WriteLine("O cinto foi colocado!");
        }

        public bool SeatBelt {get => seatBelt; set => seatBelt = value;}
    } 

    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car("350z", 100.0f, 4);
            Console.WriteLine(myCar.SeatBelt);
            myCar.PutSeatBelt();
            myCar.Move();
        }
    }
}
