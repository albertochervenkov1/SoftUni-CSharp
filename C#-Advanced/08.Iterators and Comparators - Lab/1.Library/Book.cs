﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparator
{
    public class Book
    {
        public Book(string title,int year,IEnumerable<string> authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(authors);
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }
    }
}
