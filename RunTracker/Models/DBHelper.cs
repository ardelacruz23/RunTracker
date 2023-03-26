using Microsoft.Identity.Client;

namespace RunTracker.Models
{
    public class DBHelper
    {
        public static IConfigurationRoot config;
        //Make GetConnectionString() static so you do NOT need to instantiate a DBHelper object before using
        public static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            config = builder.Build();
            return config.GetConnectionString("RunConnectionString");
        }
    }
}
