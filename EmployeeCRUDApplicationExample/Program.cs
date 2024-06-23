namespace EmployeeCRUDApplicationExample;

class Program
{
    public class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public decimal AnnualAsalary;
        public char Gender;
        public bool IsManager;
    }
    
    static void Main(string[] args)
    {
        var employee = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Gender = 'M',
            AnnualAsalary = 5000,
            IsManager = true
        };

        Console.WriteLine($"Annual salary before update{employee.AnnualAsalary}");
        UpdateAnnualSalary(employee);
        Console.WriteLine($"Annual salary after update{employee.AnnualAsalary}");

    }

    public static void UpdateAnnualSalary(Employee employee)
    {
        employee.AnnualAsalary = 100000;
        
    }
}