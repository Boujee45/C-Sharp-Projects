using System;

class Program
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee("Oscar",23);
        Manager manager = new Manager("Oscar",23,"ict");

        employee.DisplayInfo();
        manager.DisplayInfo();
    }
}

class Employee
{
    public string Name;
    public int ID;

    public Employee(string Name,int ID)
    {
        this.Name = Name;
        this.ID = ID;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, ID: {ID}");
    }
}

class Manager : Employee
{
    public string Department;

    public Manager(string Name, int ID,string Department) : base(Name, ID)
    {
        this.Department = Department;
    }

    public override void DisplayInfo()
    {
        //base.DisplayInfo();
        Console.WriteLine($"Department: {Department}");
    }
}
