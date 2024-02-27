using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Utilities
    {
        

// Class for employee
public class Employee
    {
        // Attributes for name and salary
        public string Name { get; set; }
        public double Salary { get; set; }

        // Constructor for a new employee 
        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        // Print the employee
        public void PrintEmployeeDetails()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }

    // Class for employee registry
    public class EmployeeRegistry
    {
        // Attribute for a list of employees
        private List<Employee> employees;

        // Constructor for a new employee registry
        public EmployeeRegistry()
        {
            employees = new List<Employee>();
        }

        // Method to add an employee to the registry
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        // print the registry
        public void PrintRegistry()
        {
            Console.WriteLine("Employee Registry:");
            foreach (var employee in employees)
            {
                employee.PrintEmployeeDetails();
            }
        }
    }

    // Interacting with the employee registry
    public class EmployeeRepository
    {
        // Create a new employee and add it to the registry
        public static void AddEmployeeToRegistry(EmployeeRegistry registry, string name, double salary)
        {
            Employee employee = new Employee(name, salary);
            registry.AddEmployee(employee);
        }

        // Print the registry
        public static void PrintEmployeeRegistry(EmployeeRegistry registry)
        {
            registry.PrintRegistry();
        }
    }

    
}

}
