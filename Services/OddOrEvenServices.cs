using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace EstradaBMiniChallengeFiveToSeven.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(int num)
        {
                if (num % 2 == 0)
                {
                    return $"The number you gave {num}, is an even number";
                }
                else
                {
                    return $"The number you gave {num}, is an odd number";
                }
        }
    }
}