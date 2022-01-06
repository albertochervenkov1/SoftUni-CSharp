using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparator
{
    public class Library<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        public Library(IEnumerable<T> books)
        {
            this.books = new List<T>(books);
        }
        public Library()
        {
            books = new List<T>();
        }
        private readonly SortedList<T> books;

        public IEnumerator<T> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

}
