using Task_8;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            Library library = new Library(books);

            while (true)
            {
                Console.WriteLine("1.Добавить книгу");
                Console.WriteLine("2.Найти книгу по автору");
                Console.WriteLine("3.Найти книгу по году выпуска");
                Console.WriteLine("Выберите действие");
                int n = int.Parse(Console.ReadLine());
                switch(n)
                {
                    case 1:
                        Console.Clear();    
                        Console.Write("Имя автора: ");
                        string name = Console.ReadLine();
                        Console.Write("Фамилия: ");
                        string surname = Console.ReadLine();
                        Console.Write("Дата рождения автора: ");
                        DateTime birthday = Convert.ToDateTime(Console.ReadLine());
                        Author author = new(name, surname, birthday);
                        Console.Write("Введите название книги: ");
                        string title = Console.ReadLine();
                        Console.Write("Год выпуска: ");
                        string publicyear = Console.ReadLine();
                        Book book = new(title, author, publicyear);
                        library.Add(book);
                        Console.Clear();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Имя автора: ");
                        string searchname = Console.ReadLine();
                        Console.Write("Фамилия: ");
                        string searchsurname = Console.ReadLine();
                        Console.WriteLine();
                        library.SearchByAuthor(searchname, searchsurname);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Введите год: ");
                        string searchyear = Console.ReadLine();
                        Console.WriteLine();
                        library.SearchByYear(searchyear);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}