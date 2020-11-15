using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace Public_KEY_crypthosystems
{
    class CypherCode
    {
        public static bool MillerRabinTest(int n, int k)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            int r = 0, d = n - 1;
            while (d % 2 == 0)
            {
                d /= 2;
                r++;
            }

            var rand = new Random();

            for (int i = 0; i < k; i++)
            {
                int a = rand.Next(2, n - 1);
                BigInteger x = BigInteger.ModPow(a, d, n);
                if (x == 1 || x == n - 1)
                    continue;
                for (int j = 0; j < r - 1; j++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                        break;
                }
                if (x != n - 1)
                    return false;
            }
            return true;
        }

    }
}
