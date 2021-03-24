using System.Threading.Tasks;
using thiagomotadev.OperationalResearchForEducation.Application.ValueObjects;

namespace thiagomotadev.OperationalResearchForEducation.Application.Ports
{
    public interface IIntegerOptimizer
    {
        public Task<OptimizationSolution> Solve(OptimizationProblem problem);
    }
}
