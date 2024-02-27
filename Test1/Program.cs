// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using static Test1.Utilities;

class Program
{
    static void Main(string[] args)
    {
        //  new employee registry
        EmployeeRegistry registry = new EmployeeRegistry();

        // Add employees to the registry
        EmployeeRepository.AddEmployeeToRegistry(registry, "Fall", 30000);
        EmployeeRepository.AddEmployeeToRegistry(registry, "Habib", 35000);
        EmployeeRepository.AddEmployeeToRegistry(registry, "Sidi", 32000);

        // Print the registry 
        EmployeeRepository.PrintEmployeeRegistry(registry);
    }
}
