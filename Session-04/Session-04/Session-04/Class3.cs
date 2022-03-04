using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class3
    {
        public Class3()
        {

        }

        private bool isPrime(int num)
        {
            if (num <= 1) 
                return false;
            if (num <= 3)
                return true;
            if (num % 2 == 0 || num % 3 == 0)
                return false;
            for (int i = 5; i * i <= num; i += 6)
            {
                if (num % i == 0 || num % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        public void PrimeNumbers(int num)
        {
            for (int i = 2; i <= num; i++)
            {
                if (isPrime(i))
                    Console.Write(i + " ");
            }
        }

    }
}
