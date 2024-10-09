using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Please enter your grade percentage");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string grade_letter;
        if (grade >= 90)

        {
            grade_letter = "A";
        }
        else if (grade >= 80)
        {
            grade_letter = "B";
        }
        else if (grade >= 70)
        {
            grade_letter = "C";
        }
        else if (grade >= 60)
        {
            grade_letter = "D";
        }
        else
        {
            grade_letter = "F";
        }        

        Console.WriteLine($"Your letter grade is {grade_letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congradulations you passed the test!");
        }    
        else
        {
                        Console.WriteLine("Aaaaand you failed!");

        }
        }
}