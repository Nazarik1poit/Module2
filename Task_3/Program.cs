Author author1 = new("Бурдыко Назар Дмитриевич", "22.09.2006");
Author author2 = new("Александр Сергеевич Пушкин", "01.01.1805");
Book book1 = new("Как стать программистом", author1, "25.08.2024");
Book book2 = new("Евгений Онегин", author2, "31.03.1833");
author1.Print();
book1.PrintBook();
author2.Print();
book2.PrintBook();

public class Author
{
    public string name;
    public string birthday;

    public Author (string name, string birthday)
    {
        this.name = name;
        this.birthday = birthday;
    }

    public void Print()
    {
        Console.WriteLine($"Имя автора: {this.name}, дата рождения: {this.birthday}");
    }
}
public class Book
{
    private string title;
    private Author author;
    private string outdate;

    public Book(string title, Author author, string outdate)
    {
        this.title = title;
        this.author = author;
        this.outdate = outdate;
    }
    public void PrintBook()
    {
        Console.WriteLine($"Название книги: {this.title}, автор: {this.author.name}, дата выпуска: {this.outdate}");
    }
}