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
        public DemoResponse Echo(string input) => new MessageResponse(Responder.Echo(input));

        [HttpGet(nameof(Reverse))]
        public DemoResponse Reverse(string input) => new MessageResponse(Responder.Reverse(input));
    }
}
