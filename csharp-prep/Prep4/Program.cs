using System;
using System.Collections.Generic;

// Source: https://reactgo.com/c-sharp-get-maximum-value-from-list/
using System.Linq;

class Program
{
    static void Main(string[] args)
    {   
        /* Core 01
        List of numbers, total, average, max ... */
        List<float> numbers = new List<float>();

        float newNumber;

        do
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");
            newNumber = float.Parse(Console.ReadLine());

            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }

        } while (newNumber != 0);

        float sum = 0;
        foreach (float number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        float max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        // Stretch 01
        float smallestPositiveNumber = float.MaxValue; 
        foreach (float number in numbers)
        {
            if (number > 0 && number < smallestPositiveNumber)
            {
                smallestPositiveNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        // Stretch 02
        // Source: https://www.educative.io/answers/how-to-sort-a-list-in-c-sharp
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
         foreach (float number in numbers)
         {
            Console.WriteLine(number);
         }


    }
}