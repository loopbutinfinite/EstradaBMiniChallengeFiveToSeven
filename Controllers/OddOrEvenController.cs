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
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _OddOrEvenServices;

        public OddOrEvenController(OddOrEvenServices oddOrEvenServices)
        {
            _OddOrEvenServices = oddOrEvenServices;
        }

        [HttpPost]
        [Route("CheckOddEven/{input}")]
        public string OddEvenChecker(string input)
        {
            return _OddOrEvenServices.OddOrEven(input);
        }
    }
}