using Google.OrTools.ConstraintSolver;
using System;
using thiagomotadev.OperationalResearchForEducation.Application.ValueObjects;

namespace thiagomotadev.OperationalResearchForEducation.GoogleOrTools.Solvers
{
    public abstract class RoutingSolver
    {
        protected RoutingProblemSolution Solve(RoutingIndexManager manager, RoutingProblem problem)
        {
            var routing = new RoutingModel(manager);

            SetArcCostEvaluatorOfAllVehicles(manager, routing, problem);

            var solution = GetSolution(routing, problem);

            var result = ConvertSolution(manager, routing, solution);

            result.FirstSolutionStrategy = problem.FirstSolutionStrategy;

            return result;
        }

        protected void SetArcCostEvaluatorOfAllVehicles(RoutingIndexManager manager, RoutingModel routing, RoutingProblem problem)
        {
            routing.SetArcCostEvaluatorOfAllVehicles(routing.RegisterTransitCallback((long fromIndex, long toIndex) =>
            {
                return Convert.ToInt64(problem.DistanceMatrix.GetDistance(manager.IndexToNode(fromIndex), manager.IndexToNode(toIndex)));
            }));
        }

        protected Assignment GetSolution(RoutingModel routing, RoutingProblem problem)
        {
            var searchParameters = operations_research_constraint_solver.DefaultRoutingSearchParameters();
            searchParameters.FirstSolutionStrategy = (Google.OrTools.ConstraintSolver.FirstSolutionStrategy.Types.Value)problem.FirstSolutionStrategy.Code;
            return routing.SolveWithParameters(searchParameters);
        }

        protected RoutingProblemSolution ConvertSolution(RoutingIndexManager manager, RoutingModel routing, Assignment solution)
        {
            var result = new RoutingProblemSolution();

            long routeDistance = 0;

            var index = routing.Start(0);
            while (routing.IsEnd(index) == false)
            {
                result.Route.Add(manager.IndexToNode((int)index));


                var previousIndex = index;
                index = solution.Value(routing.NextVar(index));
                routeDistance += routing.GetArcCostForVehicle(previousIndex, index, 0);
            }

            result.Route.Add(manager.IndexToNode((int)index));
            result.Distance = routeDistance;

            return result;
        }
    }
}
