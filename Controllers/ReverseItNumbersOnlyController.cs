using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EstradaBMiniChallengeFiveToSeven.Services;

namespace EstradaBMiniChallengeFiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItNumbersOnlyController : ControllerBase
    {
        private readonly ReverseItNumbersOnlyServices _ReverseItNumbersOnlyServices;

        public ReverseItNumbersOnlyController(ReverseItNumbersOnlyServices reverseItNumbersOnlyServices)
        {
            _ReverseItNumbersOnlyServices = reverseItNumbersOnlyServices;
        }

        [HttpPost]
        [Route("ReversingNumbersOnly/{userInput}")]
        public string ReverseNumbersOnlyinator(string userInput)
        {
            return _ReverseItNumbersOnlyServices.ReversedNumberSequence(userInput);
        }
    }
}