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

        [HttpGet(nameof(Encrypt))]
        public DemoResponse Encrypt(string input) => new MessageResponse(SpyMaster.Encrypt(input));

        [HttpGet(nameof(Decrypt))]
        public DemoResponse Decrypt(string input) => new MessageResponse(SpyMaster.Decrypt(input));
    }
}
