using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingLINQ
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public override string ToString() 
        {
            return $"{Title} {Author} {Price}";
        }
    }

    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "GOT", Author = "J.K.R", Price = 20.10d},
                new Book() {Title = "WITCHER", Author = "L.L", Price = 25.50d},
                new Book() {Title = "OLOCO", Author = "J.J.K", Price = 22.20d},
                new Book() {Title = "HP", Author = "J.J.K", Price = 22.20d},
                new Book() {Title = "HP", Author = "J.J.K", Price = 24.20d},
            };
        }
    }
    internal class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // FILTERING
            // Where, OfType
            Print("Where:", books.Where(p => p.Title == "HP") );

            // SORTING
            // OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse
            Print("OrderBy:", books.OrderBy(p => p.Price));
            Print("ThenBy:", books.OrderBy(p => p.Price).ThenBy(p => p.Title));

            // SET
            // Distinct, Except, Intersect, Union

            // QUANTIFICATION
            // All, Any, Contains

            // PROJECTION
            // Select, SelectMany
            Print("Select: ", books.Select(p => p.Author) );
            Print("Select 2: ", books.Select(p => new { p.Title, p.Price }) );

            // PARTITION (PAGINATION)
            // Skip, Take
            Print("Skil and Take: ", books.Skip(1).Take(2));

            // JOIN
            // join, GroupJoin

            // GROUPING 
            // GroupBy

            // GENERATIONAL
            // Empty

            // EQUATILITY
            // SequenceEquals

            // ELEMENT
            // ElementAt, First, FirstOrDefault, Last, LasOrDefault, Sign, SignOrDefaulr
            //Print("SignOrDefault: ", books.Where(p => p.Title == "OLOCO").SingleOrDefault());

            // CONVERSIONS
            // AsEnumerable, AsQueryable

            // CONCATENATION
            // Concat

            // AGGREGATION 
            // Aggregation, Average, Count, LongCount, Max, Min, Sum


        }
    }
}
