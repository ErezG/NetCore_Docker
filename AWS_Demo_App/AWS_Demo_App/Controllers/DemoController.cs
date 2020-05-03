using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWS_Demo_App.ResponseModels;
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
        public DemoResponse Echo(string input) => new EchoResponse(input);
    }
}
