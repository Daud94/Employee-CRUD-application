namespace EmployeeComponent.Data;

public class Employee
{
    private static int _nextId = 0;
    private int _id = 0;

    private string _firstName = string.Empty;
    private string _lastName = string.Empty;
    private decimal _annualSalary = 0;
    private char _gender = '\0';
    private bool _isManager = false;


    public int Id => _id;

    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public decimal AnnualSalary
    {
        get => _annualSalary;
        set => _annualSalary = value;
    }

    public char Gender
    {
        get => _gender;
        set => _gender = value;
    }

    public bool IsManager
    {
        get => _isManager;
        set => _isManager = value;
    }

    public Employee()
    {
        _nextId++;
        _id = _nextId;
    }

    public Employee(string firstName, string lastName, decimal annualSalary, char gender, bool isManager): this()
    {
        _firstName = firstName;
        _lastName = lastName;
        _annualSalary = annualSalary;
        _gender = gender;
        _isManager = isManager;
    }

    public string GetEmployeeInformation()
    {
        string employeeInformation =
            $"{Id.ToString().PadRight(6)}\t{FirstName.PadRight(15)}\t{LastName.PadRight(15)}\t{AnnualSalary.ToString().PadRight(15)}\t{Gender.ToString().PadRight(6)}\t{IsManager.ToString().PadRight(7)}";
        return employeeInformation;
        
    }
}