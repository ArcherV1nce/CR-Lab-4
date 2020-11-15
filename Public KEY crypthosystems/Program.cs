using System;

namespace Public_KEY_crypthosystems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int test = 59;
            Console.WriteLine("Miller-Rabin rusult for " + test + 
                " is " + CypherCode.MillerRabinTest(test, 7));
        }
    }
}
