using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingLINQ
{
    public class Book
    {
        private string title;
        private string author;

        public string Title { get; set; }
        public string Author { get; set; }
        
    }
    
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "HP1", Author = "J.J.K" },
                new Book() {Title = "HP2", Author = "J.J.K"},
                new Book() {Title = "GOT", Author = "J.K.R"},
                new Book() {Title = "WITCHER", Author = "L.L"},            };
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            Console.WriteLine("### QUERY 1 ###");
            var matchBooks = books.Where(b => b.Author[0] == 'J');
            
            foreach (var book in matchBooks)
                Console.WriteLine(book.Title + " " + book.Author);

            Console.WriteLine("### QUERY 2 ###");
            var titles = books.Where(b => b.Author[0] == 'J').OrderBy(b => b.Title).Select(b => b.Title);

            foreach (var title in titles)
                Console.WriteLine(title);

            Console.WriteLine("### QUERY 3 ###");
            titles = books
                .Where(b => b.Author[0] == 'J')
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var title in titles)
                Console.WriteLine(title);

            Console.WriteLine("### QUERY 4 ###");
            titles =
                from b in books
                where b.Author[0] == 'J'
                orderby b.Title
                select b.Title;

            foreach (var title in titles)
                Console.WriteLine(title);
        }
    }
}
