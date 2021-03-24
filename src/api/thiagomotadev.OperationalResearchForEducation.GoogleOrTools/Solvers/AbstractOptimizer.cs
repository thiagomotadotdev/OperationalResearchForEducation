using Google.OrTools.LinearSolver;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thiagomotadev.OperationalResearchForEducation.Application.ValueObjects;

namespace thiagomotadev.OperationalResearchForEducation.GoogleOrTools.Solvers
{
    public abstract class AbstractOptimizer
    {
        private readonly ScriptOptions scriptOptions = ScriptOptions.Default;

        protected abstract string SolverType { get; }
        protected abstract InternalVariable MakeVar(Solver solver, string name);

        public class InternalVariable
        {
            public string Name { get; set; }

            public Google.OrTools.LinearSolver.Variable Variable { get; set; }
        }

        public class LinearProgrammingSolverGlobals
        {
            public List<InternalVariable> variables;

            public Solver solver;
        }

        public async Task<OptimizationSolution> Solve(OptimizationProblem problem)
        {

            Solver solver = Solver.CreateSolver(this.SolverType);

            var variables = GetVariables(solver, problem); 

            await AddRestrictions(solver, problem, variables);

            await SetObjective(solver, problem, variables);

            if (solver.Solve() != Solver.ResultStatus.OPTIMAL)
                throw new Exception("The problem does not have an optimal solution!");

            return new OptimizationSolution
            {
                Result = (int)Math.Round(solver.Objective().Value(), 0, MidpointRounding.AwayFromZero),

                Variables = variables.Select(x => new Application.ValueObjects.Variable
                {
                    Name = x.Name,
                    Value = (int)x.Variable.SolutionValue()
                }).ToList()
            };
        }

        private List<InternalVariable> GetVariables(Solver solver, OptimizationProblem problem)
        {
            var variables = new List<InternalVariable>();

            foreach (var variable in problem.Variables)
                variables.Add(MakeVar(solver, variable));

            return variables;
        }

        private async Task AddRestrictions(Solver solver, OptimizationProblem problem, List<InternalVariable> variables)
        {
            foreach (var restritionEquation in problem.RestrictionExpressions)
            {
                var code = restritionEquation;
                for (var i = 0; i < variables.Count; i++)
                {
                    code = code.Replace(variables[i].Name, $"variables[{i}].Variable");
                }
                await EvaluateSolverAdd(solver, variables, code);
            }
        }

        private async Task SetObjective(Solver solver, OptimizationProblem problem, List<InternalVariable> variables)
        {
            var code = problem.ObjectiveExpression;

            for (var i = 0; i < variables.Count; i++)
                code = code.Replace(variables[i].Name, $"variables[{i}].Variable");

            if (problem.SolveType.Equals(LinearSolveType.Minimize))
                await EvaluateSolverMinimize(solver, variables, code);

            if (problem.SolveType.Equals(LinearSolveType.Maximize))
                await EvaluateSolverMaximize(solver, variables, code);
        }

        private Task EvaluateSolverAdd(Solver solver, List<InternalVariable> variables, string code)
        {
            return CSharpScript.EvaluateAsync($"solver.Add({code})", options: scriptOptions, globals: new LinearProgrammingSolverGlobals { solver = solver, variables = variables });
        }

        private Task EvaluateSolverMinimize(Solver solver, List<InternalVariable> variables, string code)
        {
            return CSharpScript.EvaluateAsync($"solver.Minimize({code})", options: scriptOptions, globals: new LinearProgrammingSolverGlobals { solver = solver, variables = variables });
        }

        private Task EvaluateSolverMaximize(Solver solver, List<InternalVariable> variables, string code)
        {
            return CSharpScript.EvaluateAsync($"solver.Maximize({code})", options: scriptOptions, globals: new LinearProgrammingSolverGlobals { solver = solver, variables = variables });
        }
    }
}
