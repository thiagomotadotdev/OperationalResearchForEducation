using thiagomotadev.OperationalResearchForEducation.Application.ValueObjects;

namespace thiagomotadev.OperationalResearchForEducation.Application.Ports
{
    public interface IRoutingSolver
    {
        public RoutingProblemSolution Solve(RoutingProblem problem);
    }
}
