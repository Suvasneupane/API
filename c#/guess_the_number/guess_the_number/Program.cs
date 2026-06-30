using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();
        int secret = rand.Next(0, 1000);
        int guess;

        Console.WriteLine("Enter your Name: ");
        string name= Console.ReadLine();

        Console.WriteLine("Guess the number (0 - 999)");

        for (; ; )
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess > secret)
            {
                Console.WriteLine("lower than "+guess);
            }
            else if (guess < secret)
            {
                Console.WriteLine("higher than "+guess);
            }
            else
            {
                Console.Write(name);
                Console.WriteLine(" You guessed it.Correct!");
                break;
            }
        }
    }
}