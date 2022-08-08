using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningSpace
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;


        //New Book in program.cs is directly connected to this constructor
        public Book(string aTitle, string aAuthor, int aPages) 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

    }
}
