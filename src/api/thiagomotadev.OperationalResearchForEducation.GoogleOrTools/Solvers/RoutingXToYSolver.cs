using Google.OrTools.ConstraintSolver;
using thiagomotadev.OperationalResearchForEducation.Application.Ports;
using thiagomotadev.OperationalResearchForEducation.Application.ValueObjects;

namespace thiagomotadev.OperationalResearchForEducation.GoogleOrTools.Solvers
{
    public class RoutingXToYSolver :  RoutingSolver, IRoutingXToYSolver
    {
        public RoutingProblemSolution Solve(RoutingProblem problem)
        {
            return Solve(new RoutingIndexManager(problem.NumberOfPoints, 1, new int[] { problem.StartPoint }, new int[] { problem.EndPoint }), problem);
        }
    }
}
