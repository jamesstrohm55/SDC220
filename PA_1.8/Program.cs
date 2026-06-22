/*******************************************************************
 * Name: James Strohm
 * Date: 2026-06-21
 * Assignment: SDC220 Performance Assessment - Classes
 *
 * Main application class.
 * This application demonstrates constructors, class methods, and
 * class properties using an Employee class. Two Employee objects
 * are created (one with an invalid salary), their information is
 * displayed, then updated and displayed again.
 */
public class EmployeeTest
{
    static void Main(string[] args)
    {
        // Screenshot 1 - header line
        Console.WriteLine("James Strohm - Week 1 PA Classes");

        // Create two Employee objects; emp2 uses an invalid salary (< 1000)
        Employee emp1 = new Employee("Alice", "Johnson", 4500.00);
        Employee emp2 = new Employee("Bob",   "Smith",    750.00);

        // Screenshot 2 - initial employee information
        Console.WriteLine("\n--- Initial Employee Information ---");
        PrintEmployee(emp1);
        PrintEmployee(emp2);

        // Update employee information
        emp1.SetLastName("Williams");           // update last name of emp1
        emp2.SetFirstName("Robert");            // update first name of emp2
        emp1.SetMonthlySalary(5200.00);         // update salary of emp1
        emp2.SetMonthlySalary(3800.00);         // update salary of emp2 (now valid)

        // Screenshot 3 - updated employee information
        Console.WriteLine("\n--- Updated Employee Information ---");
        PrintEmployee(emp1);
        PrintEmployee(emp2);
    }

    static void PrintEmployee(Employee emp)
    {
        Console.WriteLine("Name:           {0} {1}", emp.FirstName, emp.LastName);
        Console.WriteLine("Monthly Salary: ${0:F2}", emp.MonthlySalary);
        Console.WriteLine();
    }
}
