
using System.Diagnostics;

class Program
{
    [DebuggerDisplay("{Name}, {Department} : {Salary}")]
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee()
        {
            Name = "Hüseyin Yılmaz",
            Department = "IT",
            Salary = 500
        });
        employees.Add(new Employee()
        {
            Name = "Arif Işık",
            Department = "Sales",
            Salary = 100
        });
        employees.Add(new Employee()
        {
            Name = "216",
            Department = "Robotic",
            Salary = 1
        });
        employees.Add(new Employee()
        {
            Name = "Amir Tocha",
            Department = "Management",
            Salary = 999999
        });


      Debugger.Break();
    }
}




