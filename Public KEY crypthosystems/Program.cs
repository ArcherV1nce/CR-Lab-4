using System;

namespace Public_KEY_crypthosystems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = true;
            Console.WriteLine("Hello, User!");
            do
            {
                var rnd = new Random();
                int test = rnd.Next();
                Console.WriteLine("Miller-Rabin rusult for " + test +
                    " is " + CypherCode.MillerRabinTest(test, 64));
                if (Console.ReadLine() == null) { input = false; }
            }
            while (input);
        }
    }
}
