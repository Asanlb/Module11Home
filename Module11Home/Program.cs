using System;

enum Vacancies
{
    Manager,
    Clerk,
    Programmer
}

struct Employee
{
    public string Name;
    public Vacancies Vacancy;
    public int[] HireDate; 
    public int Salary;

   
    public Employee(string name, Vacancies vacancy, int[] hireDate, int salary)
    {
        Name = name;
        Vacancy = vacancy;
        HireDate = hireDate;
        Salary = salary;
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Vacancy: {Vacancy}");
        Console.WriteLine($"Hire Date: {HireDate[0]}.{HireDate[1]}.{HireDate[2]}");
        Console.WriteLine($"Salary: {Salary:C}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Employee employee1 = new Employee("Bekbulat Asanali", Vacancies.Manager, new int[] { 2022, 11, 15 }, 50000);
        Employee employee2 = new Employee("Karlybau Nurasyl", Vacancies.Clerk, new int[] { 2023, 2, 28 }, 30000);

        Console.WriteLine("Employee 1:");
        employee1.DisplayInfo();

        Console.WriteLine("Employee 2:");
        employee2.DisplayInfo();
    }
}
