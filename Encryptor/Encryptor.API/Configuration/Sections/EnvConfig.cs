using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Encryptor.API.Configuration.Sections
{
    public class EnvConfig
    {
        public string Key { get; set; }
        public string Name => CTConfig.ConfigOrigin["Env:Name"];
    }
}
