/* Kode Awal
public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public double CalculateSalary()
    {
        return Salary * 1.1; // Bonus 10%
    }

    public void SaveToDatabase()
    {
        Console.WriteLine($"Saving {Name} with salary {Salary} to database...");
    }
}
*/

public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set;}

    public Employee (string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}

public class Salary
{
    public double CalculateSalary(Employee employee)
    {
        return employee.Salary * 1.1; // Bonus 10%
    }
}

public class Repository
{
    public void SaveToDatabase(Employee employee)
    {
        Console.WriteLine($"Saving {employee.Name} with salary Rp. {employee.Salary:N0} to database...");
    }
}

public class oop2
{
    static void Main() 
    {
        Employee employee = new Employee("Udin", 2000000);
        Salary salary = new Salary();
        Repository repository = new Repository();

        double totalsalary = salary.CalculateSalary(employee);
        Console.WriteLine($"Total Salary for {employee.Name}: Rp. {totalsalary:N0}");

        repository.SaveToDatabase(employee);
    }
}