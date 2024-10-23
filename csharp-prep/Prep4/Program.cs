using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Please enter a number when prompted, enter 0 when finished");
        List<double> numbers = new List<double>();
        string number;
        double number_convert=1;
        double av = 0;
        double total = 0;
        double max;
        while (number_convert != 0)
        {
            Console.WriteLine("Enter a number");
            number = Console.ReadLine();
            number_convert = double.Parse(number);
            if (number_convert != 0)
            {
                numbers.Add(number_convert);
            }
        }
    foreach (int integer in numbers)
    {
        total += integer;

    
    }
    av = total/(numbers.Count);
    max = numbers[0];
    foreach (int num in numbers)
    {
        if (max < num)
        {
            max = num;
        }
    }
    Console.WriteLine($"The Total is: {total}");
    Console.WriteLine($"The Average is: {av}");
    Console.WriteLine($"The maximum is: {max}");

    }
}