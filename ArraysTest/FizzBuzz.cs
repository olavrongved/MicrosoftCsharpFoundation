using System.Runtime.InteropServices;

public class FizzBuzz
{
    public static void DoFizzBuzzin(int numberOfIterations)
    {
        string fizzbuzz;
        for (int i = 1; i <= numberOfIterations; i++)
        {
            fizzbuzz = "";
            if (i % 3 == 0)
            {
                fizzbuzz = "Fizz";
            }

            if ( i % 5 == 0)
            {
                fizzbuzz += "Buzz";
            }

            Console.WriteLine(i + ":  " + fizzbuzz);
        }
    }
}