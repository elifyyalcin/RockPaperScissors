using System;
namespace ConsoleApp1
{
    public class numberGenerator
    {
        public int RandomNumber()
        {
            int a;
            Random r = new Random();
            a = r.Next(0, 3);
            return a;
        }

        static void Main(string[] args)
        {

            int A = 0;
            int B = 0;
            int tie;
            int b;
            string aState = "paper";
            string bState;



            string[] state = new string[3] { "rock", "paper", "scissors" };

            for (int j = 0; j < 100; j++)
            {

                numberGenerator obj = new numberGenerator();
                b = obj.RandomNumber();
                bState = state[b];
                if (Equals(bState, state[2]))
                {
                    B++;
                }
                else if (Equals(bState, state[0]))
                {
                    A++;
                }
                else { }
            }

            tie = 100 - (A + B);

            Console.WriteLine("Player A wins " + A + " of 100 games");
            Console.WriteLine("Player B wins " + B + " of 100 games");
            Console.WriteLine("Tie: " + tie + " of 100 games");
            Console.ReadKey();

        }
    }

}
