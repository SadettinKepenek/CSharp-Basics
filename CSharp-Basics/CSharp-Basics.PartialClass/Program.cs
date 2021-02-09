using System;

namespace CSharp_Basics.PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "Doe");
            var fullName = employee.GetFullName();
            Console.WriteLine(fullName);
        }
    }
}