using System;

namespace IteratorsAndComparator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            //Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            //Book bookThree = new Book("The Documents in the Case", 1930);

            //Library libraryOne = new Library();
            //Library libraryTwo = new Library(bookOne, bookTwo, bookThree);
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
