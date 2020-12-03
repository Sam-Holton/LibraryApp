//text file is listOfBooks.txt
namespace LibraryApp
{
    partial class Program
    {
        public class Book

        {

            public Book()
            {
                Author = string.Empty;
                Title = string.Empty;
                Status = string.Empty;
                DueDate = string.Empty;
               
            }

            public Book(string author, string title, string status, string dueDate)
            {
                Author = author;
                Title = title;
                Status = status;
                DueDate = dueDate;
            }

            public string Author { get; set; }

            public string Title { get; set; }

            public string Status { get; set; }

            public string DueDate { get; set; }
            public string Mainlist { get; set; }
        }
    }

}
