using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            
            Console.Write("Guess the number:    ");
            
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}
