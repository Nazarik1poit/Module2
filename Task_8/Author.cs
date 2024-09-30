using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    public class Author
    {
        string name;
        string surname;
        DateTime birthday;

        public Author(string name, string surname, DateTime birthday)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
        }
        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public DateTime GetBirthday()
        {
            return this.birthday;
        }
    }
}
