using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13_24_06_2024
{
    public static class IsPrime
    {
        public static bool IsPrimeNum(this int number)
        {
            if (number <= 1) return false;
            else if (number == 2) return true;
            int var = (int)Math.Sqrt(number);
            for (int i = 2; i <= var; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
