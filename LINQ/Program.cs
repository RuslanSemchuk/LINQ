using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 25, 7, 42, 15, 30, 5, 18, 50 };

        var filteredNumbers = numbers.Where(num => num > 20);

        var sortedNumbers = numbers.OrderBy(num => num);

        var firstMultipleOf3 = numbers.FirstOrDefault(num => num % 3 == 0);

        var groupedNumbers = numbers.GroupBy(num => num % 10);

        Console.WriteLine("All numbers are greater than 20:");
        foreach (var num in filteredNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nThe numbers are sorted in ascending order:");
        foreach (var num in sortedNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nThe first number that is a multiple of 3: " + firstMultipleOf3);

        Console.WriteLine("\nGroups of numbers by the remainder of division by 10:");
        foreach (var group in groupedNumbers)
        {
            Console.WriteLine($"Remainder {group.Key}: {string.Join(", ", group)}");
        }
    }
}