using CompositionUML.Entities;
using CompositionUML.Entities.Hellpers;
using System.Globalization;
using System;

namespace CompositionUML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior)? ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("How many contracts to this worker? ");
            int manyContracts = int.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            for (int i = 0; i < manyContracts; i++)
            {
                Console.Write($"Enter #{i+1} contract data: ");
                Console.Write($"Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write($"Value per hour: ");
                double value = double.Parse(Console.ReadLine());
                Console.Write($"Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, value, duration);
                worker.AddContract(contract);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] dateSlice = Console.ReadLine().Split("/");
            int monthIncome = int.Parse(dateSlice[0]);
            int yearIncome = int.Parse(dateSlice[1]);
            double valueIncome = worker.Income(yearIncome, monthIncome);
            Console.WriteLine($"Total salary = R$ {valueIncome}");
        }
    }
}
