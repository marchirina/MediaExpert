using System;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace MediaExpert.Configurations
{
	public class ConfigurationManager
    {
        public static IConfiguration AppSetting { get; }
        static ConfigurationManager()
        {
            AppSetting = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("Configurations/Environment.json")
                    .Build();
        }
    }
}


