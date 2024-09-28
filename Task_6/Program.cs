Employee employee = new("Алексей", 45, "Уборщик", 345);
Employee employee1 = new("Дмитрий", 23, "Заведующий хозяйством", 785);
employee.PrintInfo();
employee1.PrintInfo();
Console.WriteLine("Изменим некоторую информацию о работниках");
employee.SetSalary(370);
employee1.SetAge(24);
employee.PrintInfo();
employee1.PrintInfo();
Console.WriteLine($"Годовой доход сотрудника {employee.GetName()} - {employee.GetYearSalary()}");
Console.WriteLine($"Годовой доход сотрудника {employee1.GetName()} - {employee1.GetYearSalary()}");

public class Employee
{
    string name;
    int age;
    string occupation;
    int salary;

    public Employee(string name, int age, string occupation, int salary)
    {
        this.name = name;
        this.age = age;
        this.occupation = occupation;
        this.salary = salary;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return this.age;
    }

    public void SetOccupation(string occupation)
    {
        this.occupation = occupation;
    }

    public string GetOccupation()
    {
        return this.occupation;
    }

    public void SetSalary(int salary)
    {
        this.salary = salary;
    }

    public int GetSalary()
    {
        return this.salary;
    }

    public int GetYearSalary()
    {
        return this.salary*12;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {this.name}, возраст: {this.age}, должность: {this.occupation}, месячный доход: {this.salary}");
    }
}