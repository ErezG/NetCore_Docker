using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWS_Demo_App.ResponseModels;
using DemoApp.BL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AWS_Demo_App.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public DemoResponse Get() => new DemoResponse();

        [HttpGet(nameof(Echo))]
        public async Task<DemoResponse> Echo(string input, bool encrypt = false)
        {
            var output = await Responder.Echo(input, encrypt);
            return new MessageResponse(output);
        }

        [HttpGet(nameof(Reverse))]
        public async Task<DemoResponse> Reverse(string input, bool encrypt)
        {
            var output = await Responder.Reverse(input, encrypt);
            return new MessageResponse(output);
        }
    }
}
