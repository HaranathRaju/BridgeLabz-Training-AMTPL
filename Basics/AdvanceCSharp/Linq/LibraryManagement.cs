using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.AdvanceCSharp.Linq
{
    class Book
    {
        public int id;
        public String title;
        public String author;
        public double price;

        public Book(int id, String title, String author, double price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public override string ToString()
        {
            return "id :" + id + " title: " + title + " author: " + author + " price: " + price;
        }
    }

    internal class LibraryManagement
    {
        public static void Main (string[] args)
        {
            List<Book> books = new List<Book>();
            Book b1 = new Book(1, "java", "jhon", 750);
            Book b2 = new Book(2, "python", "bob", 550);
            Book b3 = new Book(3, "c#", "carley", 350);
            Book b4 = new Book(4, "html", "tyson", 300);
            Book b5 = new Book(5, "css", "tyson", 450);
            Book b6 = new Book(6, "javascript", "mike", 650);
            books.Add(b1);
            books.Add(b2);
            books.Add(b3);
            books.Add(b4);
            books.Add(b5);
            books.Add(b6);

            var sorting = books.Where(n => n.price > 500)
                .OrderBy(n => n.price);

            foreach(var i in sorting)
            {
                Console.WriteLine(i);
            }

            HashSet<string> unqauthors = books.Select(n => n.author).ToHashSet();

            foreach( var i in unqauthors)
            {
                Console.WriteLine(i);
            }

            var expensivebook = books.OrderBy(n => n.price)
            .LastOrDefault();

            if (expensivebook!=null)
            {
                Console.WriteLine(expensivebook);
            } else
            {
                Console.WriteLine("book is not available");
            }

        }
    }
}
