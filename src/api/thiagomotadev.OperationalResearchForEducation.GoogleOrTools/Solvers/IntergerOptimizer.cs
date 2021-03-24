using Google.OrTools.LinearSolver;
using thiagomotadev.OperationalResearchForEducation.Application.Ports;
using System.Text.RegularExpressions;

namespace thiagomotadev.OperationalResearchForEducation.GoogleOrTools.Solvers
{
    public class IntergerOptimizer : AbstractOptimizer, IIntegerOptimizer
    {
        protected override string SolverType => "SCIP";

        protected override InternalVariable MakeVar(Solver solver, string name)
        {
            if (Regex.Match(name, "^[A-Za-z][A-Za-z0-9=<>*-=]*$").Success)
                return new InternalVariable
                {
                    Name = name,
                    Variable = solver.MakeIntVar(0, int.MaxValue, name)
                };

            if (Regex.Match(name, "^[A-Za-z][A-Za-z0-9=<>*-=]* bool").Success)
            {
                name = name.Replace(" bool", "");
                return new InternalVariable
                {
                    Name = name,
                    Variable = solver.MakeBoolVar(name)
                };
            }

            return null;
        }
    }
}
