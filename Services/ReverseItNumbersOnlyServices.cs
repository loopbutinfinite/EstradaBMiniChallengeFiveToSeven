using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace EstradaBMiniChallengeFiveToSeven.Services
{
    public class ReverseItNumbersOnlyServices
    {
        public long ReversedNumberSequence(long userNumInput)
        {
            long reversedNum = 0;
            for (long i = userNumInput; i > 0; i /= 10)
            {
                long lastDigit = i % 10;               
                reversedNum = (reversedNum * 10) + lastDigit;
            }
            return reversedNum;
        }
    }
}