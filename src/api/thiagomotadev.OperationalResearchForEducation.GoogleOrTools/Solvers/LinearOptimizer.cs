using Google.OrTools.LinearSolver;
using thiagomotadev.OperationalResearchForEducation.Application.Ports;

namespace thiagomotadev.OperationalResearchForEducation.GoogleOrTools.Solvers
{
    public class LinearOptimizer : AbstractOptimizer, ILinearOptimizer
    {
        protected override string SolverType => "GLOP";

        protected override InternalVariable MakeVar(Solver solver, string name)
        {
            return new InternalVariable {
                Name = name,
                Variable = solver.MakeIntVar(0.0, double.PositiveInfinity, name)
            };
        }
    }
}
