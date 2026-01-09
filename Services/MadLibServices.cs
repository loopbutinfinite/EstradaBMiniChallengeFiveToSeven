using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstradaBMiniChallengeFiveToSeven.Services
{
    public class MadLibServices
    {
        public string MadlibStory(string name, string occupation, string unusualObject)
        {
            return $"Yesterday, {name} was busy working as a professional {occupation} when they tripped over something hidden in the grass. Much to their surprise, it was {unusualObject}! Without hesitating, they picked it up and realized their life would never be the same again.";
        }
    }
}