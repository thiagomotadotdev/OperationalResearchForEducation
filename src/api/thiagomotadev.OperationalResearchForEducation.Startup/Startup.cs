using Microsoft.Extensions.DependencyInjection;

namespace thiagomotadev.OperationalResearchForEducation.Startup
{
    public class Startup : Application.Ports.IStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            new Application.Startup().ConfigureServices(services);
            new GoogleOrTools.Startup().ConfigureServices(services);
        }
    }
}
