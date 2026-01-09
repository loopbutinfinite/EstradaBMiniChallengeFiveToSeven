using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstradaBMiniChallengeFiveToSeven.Services
{
    public class ReverseItAlphanumericServices
    {
        public string AlphanumericReversed(string userInput)
        {
            string reversed = "";
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                reversed += userInput[i];
            }
            return reversed;
        }
    }
}