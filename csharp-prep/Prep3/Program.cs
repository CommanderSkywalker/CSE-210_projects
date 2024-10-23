using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Here you will guess a random number between 1 ande 100.");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        string guess;
        int guess_number;
        Console.WriteLine("Please enter your guess now.");
        do
        {
        guess = Console.ReadLine();
        guess_number = int.Parse(guess);
        if (guess_number > number){
            Console.WriteLine("Lower");
        }
        else if (guess_number < number){
            Console.WriteLine("Higher");
        }
    } while (guess_number != number);
    Console.WriteLine("You guessed it!");
    }
}