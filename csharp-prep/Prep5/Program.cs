using System;


class Program
{
        static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your username");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number (as an integer)");
        string number = Console.ReadLine();
        int number_convert = int.Parse(number);
        return number_convert;
    }
    static int SquareNumber(int favorite_number)
    {
        int square = favorite_number*favorite_number;
        return square;
    }
    static void DisplayResult(string username, int square)
    {
        Console.WriteLine($"{username}, the square of your number is, {square}");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);
    }

}