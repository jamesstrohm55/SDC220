/*******************************************************************
 * Name: James Strohm
 * Date: 2026-06-21
 * Assignment: SDC220 Performance Assessment - Classes
 *
 * Employee class.
 * This class represents an employee with a first name, last name,
 * and monthly salary. All properties use private setters and are
 * modified only through dedicated public methods. Monthly salary
 * is validated to be greater than or equal to 1000 both in the
 * constructor and in the update method.
 */
public class Employee
{
    public string FirstName { get; private set; }
    public string LastName  { get; private set; }
    public double MonthlySalary { get; private set; }

    public Employee(string firstName, string lastName, double monthlySalary)
    {
        FirstName = firstName;
        LastName  = lastName;

        if (monthlySalary >= 1000)
            MonthlySalary = monthlySalary;
    }

    public void SetFirstName(string firstName)
    {
        FirstName = firstName;
    }

    public void SetLastName(string lastName)
    {
        LastName = lastName;
    }

    public void SetMonthlySalary(double monthlySalary)
    {
        if (monthlySalary >= 1000)
            MonthlySalary = monthlySalary;
    }
}
