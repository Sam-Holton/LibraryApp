using System;
//text file is listOfBooks
namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static List<Book> searchIndex()
        {
            Console.WriteLine("1. Author");
            Console.WriteLine("2. Title");
            Console.Write("Please select one of the above items to search by: ");
            int userChoice;
            List<Book> bookSearch = new List<Book>;

            do
            {
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out userChoice) && userChoice > 0 && userChoice < 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please select either 1 for Author or 2 for Title: ");
                }
            } while (true);

            switch (userChoice)
            {
                case 1:
                    {
                        Console.Write("Please enter in the last name of the Author you wish to search for: ");
                        string author = Console.ReadLine();

                        foreach (string book in listOfBooks)
                        {
                            if (listOfBooks[0] == author) Console.WriteLine(Book.Title);
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("Please enter the Title of the book you are searching for: ");
                        string title = Console.ReadLine();


                    }
            }
                
        }

        public void AddBookTOList(Book newBook)
        {
            string author = newBook.Author;
            string title = newBook.Title;

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

}
