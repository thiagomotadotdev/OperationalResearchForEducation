using Google.OrTools.ConstraintSolver;
using thiagomotadev.OperationalResearchForEducation.Application.Ports;
using thiagomotadev.OperationalResearchForEducation.Application.ValueObjects;

namespace thiagomotadev.OperationalResearchForEducation.GoogleOrTools.Solvers
{
    public class TravelingSalesmanSolver : RoutingSolver, ITravelingSalesmanSolver
    {
        public RoutingProblemSolution Solve(RoutingProblem problem)
        {
            return Solve(new RoutingIndexManager(problem.DistanceMatrix.GetSize(), 1, problem.StartPoint), problem);
        }
    }
}
