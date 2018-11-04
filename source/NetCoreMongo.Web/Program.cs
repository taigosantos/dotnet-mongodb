using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace NetCoreMongo.Web
{
    public class Program
    {
        #region Public Methods

        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }

        #endregion
    }
}