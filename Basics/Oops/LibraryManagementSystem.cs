using System;

namespace ObjectOrientedProgramming.problems
{
    class Book
    {
        public static string LibraryName = "city library";
        public string Title;
        public string Author;
        public readonly int ISBN;

        public Book(string Title,string Author,int ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }

        public static void DisplayLibraryName()
        {
            Console.WriteLine("library name: " + LibraryName);
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
        }

    }
    internal class LibraryManagementSystem
    {
        public static void Main(string[] args)
        {
            Book b1=new Book("The Great Gatsby","F. Scott Fitzgerald",123456);
            Book b2=new Book("To Kill a Mockingbird","Harper Lee",789012);
            Book.DisplayLibraryName();

            if (b1 is Book)
            {
                b1.DisplayBookInfo();
            }
            if (b2 is Book)
            {
                b2.DisplayBookInfo();
            }

        }
    }
}
