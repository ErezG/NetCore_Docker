using Encryptor.API.Configuration.Sections;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Encryptor.API.Configuration
{
    public static class CTConfig
    {
        static CTConfig()
        {
            Env = new EnvConfig();
        }

        public static IConfiguration ConfigOrigin { get; set; }

        public static EnvConfig Env { get; set; }
    }
}
