using System.Threading.Tasks;
using thiagomotadev.OperationalResearchForEducation.Application.ValueObjects;

namespace thiagomotadev.OperationalResearchForEducation.Application.Ports
{
    public interface ILinearOptimizer
    {
        public Task<OptimizationSolution> Solve(OptimizationProblem problem);
    }
}
