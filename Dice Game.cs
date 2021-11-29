using System;

namespace project3
{
    class Program
    {
        static void Main(string[] args)
        {

            Random fu = new Random();
            int a;
            int b;

            int scorea = 0;
            int scoreb = 0;


            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();

                a = fu.Next(1, 7);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("You rolled a " + a);

                b = fu.Next(1, 7);
                System.Threading.Thread.Sleep(100);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("PlayerB rolled a " + b);

                if (a > b)
                {
                    scorea += a;
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("You have won this round!!!");
                    scoreb += b;
                }
                else if (a < b)
                {
                    scoreb += b;
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Playerb has won this round!!!");
                    scorea += a;
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Draw");
                }
                //make duration slow everywhere
                //add final score winner
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\nYour Score: " + scorea);
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine(" \nPlayerB Score: " + scoreb);
                Console.WriteLine("\n");
            }
            Console.WriteLine("Results Processing....");
            System.Threading.Thread.Sleep(4000);
            if (scorea > scoreb)
            {
                Console.WriteLine("You are the winner of the game, Congratulations!!!");
            }
            else if (scorea < scoreb)
            {
                Console.WriteLine("PlayerB is the winner of the game, Congratulations!!!");
            }
            else
            {
                Console.WriteLine("You and PlayerB both ended the game in a draw.");
            }
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine($"\nYour Score: {scorea}" + $"\nPlayerB Score: {scoreb}" );
            
            Console.ReadKey();
        }
    }
}
