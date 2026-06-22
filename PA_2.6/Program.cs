/*******************************************************************
 * Name: James Strohm
 * Date: 2026-06-22
 * Assignment: SDC220 Performance Assessment - Smallest Number
 *
 * Main application class.
 * This application asks the user how many integers they will enter,
 * then loops to collect that many values. It tracks the smallest
 * value entered and prints it after all values have been collected.
 */
public class SmallestNumber
{
    static void Main(string[] args)
    {
        // Screenshot 1 - header line
        Console.WriteLine("James Strohm - Week 2 PA Smallest Number");

        Console.Write("\nHow many integers will you enter? ");
        string? val = Console.ReadLine();
        int count = Convert.ToInt32(val);

        int smallest = 0;

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter integer {0}: ", i + 1);
            val = Console.ReadLine();
            int input = Convert.ToInt32(val);

            // First time through, set smallest to the value entered
            if (i == 0)
            {
                smallest = input;
            }
            // Each subsequent time, update smallest if the new value is smaller
            else if (input < smallest)
            {
                smallest = input;
            }
        }

        // Screenshot 2 - smallest value
        Console.WriteLine("\nThe smallest integer entered was: {0}", smallest);
    }
}
