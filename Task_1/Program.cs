Person person = new Person();
person.Name = "Andrey";
person.Age = 30;
person.Adress = "Republic of Belarus";
Person person1 = new Person();
person1.Name = "Artem";
person1.Age = 20;
person1.Adress = "Russian Federation";
Console.WriteLine($"Имя: {person.Name}, возраст: {person.Age}, адрес: {person.Adress}");
Console.WriteLine($"Имя: {person1.Name}, возраст: {person1.Age}, адрес: {person1.Adress}");

class Person
{
    private string name = "Undefined";
    private int age = 1;
    private string adress = "Undefined";
    
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int Age
    {
        set
        {
            age = value;
        }
        get
        {
            return age;
        }
    }
    public string Adress
    {
        get
        {
            return adress;
        }
        set
        {
            adress = value;
        }
    }
}
