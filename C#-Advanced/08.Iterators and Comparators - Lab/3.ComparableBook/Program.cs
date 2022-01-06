using System;

namespace IteratorsAndComparators
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book[] books = new Book[]
             {
                new Book("Winnie The pooh",1997,new string[]{ "A.A"}),
                new Book("Under the York",19895,new string[]{ "Ivan Vazov"})
             };
            Library<Book> myLibrary = new Library<Book>(books);

            foreach (var item in myLibrary)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
