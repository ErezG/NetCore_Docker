using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encryptor.API.ResponseModels;
using Encryptor.BL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Encryptor.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public DemoResponse Get() => new DemoResponse();

        [HttpGet(nameof(Echo))]
        public DemoResponse Echo(string input) => new MessageResponse(Responder.Echo(input));

        [HttpGet(nameof(Reverse))]
        public DemoResponse Reverse(string input) => new MessageResponse(Responder.Reverse(input));
    }
}
