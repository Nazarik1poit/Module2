using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    public class Library
    {
        List<Book> books;

        public Library(List<Book> books)
        {
            this.books = books;
        }

        public void SearchByAuthor(string name, string surname)
        {
            for (int i = 0; i < this.books.Count; i++)
            {
                if (name == this.books[i].author.GetName() && 
                    surname == this.books[i].author.GetSurname())
                {
                    this.books[i].PrintInfo();
                }
            }
        }

        public void SearchByYear(string year)
        {
            for (int i = 0; i < this.books.Count; i++)
            {
                if (year == this.books[i].GetPublicationYear())
                {
                    this.books[i].PrintInfo();
                }
            }
        }

        public void PrintBooks()
        {
            for (int i = 0;i < this.books.Count;i++)
            {
                this.books[i].PrintInfo();
                Console.WriteLine();
            }
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }
    }
}
