class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Single Responsible Principle : ");
        Employee employee = new Employee(1, "John Doe", 3000);
        SalaryCalculator salaryCalculator = new SalaryCalculator();
        EmailSender emailSender = new EmailSender();

        double annualSalary = salaryCalculator.CalculateAnnualSalary(employee);
        Console.WriteLine($"Annual Salary: {annualSalary}");

        emailSender.SendEmail("Hello, this is a test email.");
        Console.WriteLine("");
   
    }
}
