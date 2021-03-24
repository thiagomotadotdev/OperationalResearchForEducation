using Microsoft.Extensions.DependencyInjection;

namespace thiagomotadev.OperationalResearchForEducation.Application.Ports
{
    public interface IStartup
    {
        public void ConfigureServices(IServiceCollection services);
    }
}
