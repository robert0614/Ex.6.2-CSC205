namespace Ex._6._2_CSC205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double count = 0.0;
            while (count != 1.0)
            {
                count = count + 0.1;
                Console.Write("{0:R}", count);
                Console.ReadLine();
            }
        }
    }
}

/* The reason the loop does not stop when count reaches 1.0 is due to the way floating-point arithmetic works in computers.
 * Floating-point numbers are an approximation and cannot always represent decimal values exactly.
 * When you add 0.1 to count repeatedly, the accumulated value is slightly different from 1.0 due to rounding errors.
 * Therefore, count never exactly equals 1.0, causing the loop to run indefinitely. */

// Altering the code to make the loop stop when count is close enough to 1.0


//using System;

class Program
{
    static void Main(string[] args)
    {
        double count = 0.0;
        double tolerance = 1e-10; // Define a small tolerance value

        while (Math.Abs(count - 1.0) > tolerance)
        {
            count = count + 0.1;
            Console.WriteLine("{0:R}", count);
            Console.ReadLine();
        }
    }
}
/* /* TESTING: Run the corrected program.
 * Press the Enter or Return key for each iteration of the loop.
 * The program will stop when count is approximately equal to 1.0. */





