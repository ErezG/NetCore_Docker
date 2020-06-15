using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.BL.Configurations.Sections
{
    public class EnvConfig
    {
        public string Key { get; set; }
        public string Name => CTConfig.ConfigOrigin["Env:Name"];
    }
}
