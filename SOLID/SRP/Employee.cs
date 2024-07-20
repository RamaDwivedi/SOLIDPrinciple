public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double BaseSalary { get; set; }

  
    public Employee(int id, string name, double baseSalary)
    {
        Id = id;
        Name = name;
        BaseSalary = baseSalary;
    }
}

// SalaryCalculator class - responsible for calculating salaries
public class SalaryCalculator
{
    public double CalculateAnnualSalary(Employee employee)
    {
        return employee.BaseSalary * 12;
    }
}

// EmailSender class - responsible for sending email notifications
public class EmailSender
{
    public void SendEmail(string message)
    {
       Console.WriteLine(message);
    }
}
