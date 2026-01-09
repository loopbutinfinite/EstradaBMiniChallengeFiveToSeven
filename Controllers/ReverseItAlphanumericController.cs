using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EstradaBMiniChallengeFiveToSeven.Services;

namespace EstradaBMiniChallengeFiveToSeven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItAlphanumericController : ControllerBase
    {
        private readonly ReverseItAlphanumericServices _ReverseItAlphanumericServices;

        public ReverseItAlphanumericController(ReverseItAlphanumericServices reverseItAlphanumericServices)
        {
            _ReverseItAlphanumericServices = reverseItAlphanumericServices;
        }

        [HttpPost]
        [Route("Reversing/{userInput}")]
        public string reversinator(string userInput)
        {
            return _ReverseItAlphanumericServices.AlphanumericReversed(userInput);
        }
    }
}