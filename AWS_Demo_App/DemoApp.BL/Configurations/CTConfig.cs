using DemoApp.BL.Configurations.Sections;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.BL.Configurations
{
    public static class CTConfig
    {
        static CTConfig()
        {
            Env = new EnvConfig();
            Services = new ServicesConfig();
        }

        public static IConfiguration ConfigOrigin { get; set; }

        public static EnvConfig Env { get; set; }
        public static ServicesConfig Services { get; set; }
    }
}
