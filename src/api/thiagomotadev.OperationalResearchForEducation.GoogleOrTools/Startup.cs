using Microsoft.Extensions.DependencyInjection;
using thiagomotadev.OperationalResearchForEducation.Application.Ports;
using thiagomotadev.OperationalResearchForEducation.GoogleOrTools.Solvers;

namespace thiagomotadev.OperationalResearchForEducation.GoogleOrTools
{
    public class Startup : IStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRoutingXToYSolver, RoutingXToYSolver>();
            services.AddScoped<ITravelingSalesmanSolver, TravelingSalesmanSolver>();
            services.AddScoped<IIntegerOptimizer, IntergerOptimizer>();
            services.AddScoped<ILinearOptimizer, LinearOptimizer>();
        }
    }
}
