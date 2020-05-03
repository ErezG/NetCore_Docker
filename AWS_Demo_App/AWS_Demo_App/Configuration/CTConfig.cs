using AWS_Demo_App.Configuration.Sections;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWS_Demo_App.Configuration
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
