using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _009_010_HomeWork
{
    class Book
    {
        private string title;
        private string author;
        private string genre;
        private int year;

        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}, Genre: {Genre}, Year: {Year}";
        }
    }
}
