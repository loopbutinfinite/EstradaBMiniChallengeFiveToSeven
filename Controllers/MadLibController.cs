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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _MadLibServices;
        
        public MadLibController(MadLibServices madLibServices)
        {
            _MadLibServices = madLibServices;
        }

        [HttpPost]
        [Route("MadLibs/{name}/{occupation}/{unusualObject}")]
        public string OutputMadLibStory(string name, string occupation, string unusualObject)
        {
            return _MadLibServices.MadlibStory(name, occupation, unusualObject);
        }
    }
}