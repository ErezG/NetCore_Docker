using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DemoApp.BL.Configurations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AWS_Demo_App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CTConfig.Env.Key = Environment.GetEnvironmentVariable("MAIN_KEY");
            CTConfig.Services.EncryptorDomain = Environment.GetEnvironmentVariable("encryptor_domain");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {

            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    bool isDebug = false;

#if DEBUG
                    isDebug = true;
#endif

                    string configFilePath = null;
                    if (isDebug)
                    {
                        configFilePath = "demoSettings.json";
                    }
                    else //from image
                    {
                        PlaceConfigFiles();
                        configFilePath = "configs/demoSettings.json";
                    }

                    config.AddJsonFile(configFilePath,
                        optional: false,
                        reloadOnChange: true);
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseKestrel()
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        //.UseIISIntegration()
                        .UseStartup<Startup>();
                });
        }

        private static void PlaceConfigFiles()
        {
            if (!Directory.Exists("configs"))
            {
                Directory.CreateDirectory("configs");
            }
            if (File.Exists("configs/demoSettings.json"))
            {
                File.Delete("configs/demoSettings.json");
            }

            File.Move("demoSettings.json", "configs/demoSettings.json");
        }
    }
}
