using System;

namespace randomNumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            int randomNum;
            int guess;
            int guessAmount=1;
            bool correct = false;
            Random r = new Random();
            randomNum = r.Next(1, 101);
            Console.WriteLine(randomNum);
            while (correct == false)
            {
                do
                {
                    try
                    {
                        Console.WriteLine("enter guess");
                        guess = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("that is not a valid integer, try again");
                    }
                }
                while (true);
                if(randomNum == guess)
                {
                    Console.WriteLine("correct! the number was {0}", guess);
                    Console.WriteLine("guess amount was {0}", guessAmount);
                    correct = true;
                }
                else
                {
                    Console.Write("Nope! ");
                    if(guess > randomNum)
                    {
                        Console.Write("too high!");
                    }
                    else 
                    {
                        Console.Write("too low!");
                    }
                    Console.WriteLine(" try again!");
                    guessAmount++;
                }
            }
        }
    }
}
