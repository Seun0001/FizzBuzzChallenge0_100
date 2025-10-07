using System;

class Program
{
    static void Main()
    {
        string x = "Fizz";
        string y = "Buzz";
        string z = "FizzBuzz";

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine($"{i} - {z}");
            else if (i % 3 == 0)
                Console.WriteLine($"{i} - {x}");
            else if (i % 5 == 0)
                Console.WriteLine($"{i} - {y}");
            else
                Console.WriteLine(i);
        }
        Console.WriteLine("Finishing My FizzBuzz Code in 3mins...");
    }
}
