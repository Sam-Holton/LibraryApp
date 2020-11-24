using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Book

    {
        public Book()
        {
            Author = string.Empty;
            Title = string.Empty;
            Status = string.Empty;
          //  DueDate = DateTime;
        }

        public Book(string author, string title, string status, DateTime dueDate)
        {
            Author = author;
            Title = title;
            Status = status;
            DueDate = dueDate;
        }

        public string Author { get; set; }
        
        public string Title { get; set; }

        public string Status { get; set; }

        public DateTime DueDate { get; set; }

    }

}
