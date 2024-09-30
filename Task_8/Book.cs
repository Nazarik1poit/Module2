using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    public class Book
    {
        string title;
        public Author author;
        string publicyear;

        public Book(string title, Author author, string publicyear)
        {
            this.title = title;
            this.author = author;   
            this.publicyear = publicyear;
        }

        public string GetPublicationYear()
        {
            return this.publicyear;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Название книги: " + this.title);
            Console.WriteLine("Имя автора: " + this.author.GetName() + " " + this.author.GetSurname());
            Console.WriteLine("Год рождения автора: " + this.author.GetBirthday());
            Console.WriteLine("Дата выпуска: " + this.publicyear);
        }
    }
}
