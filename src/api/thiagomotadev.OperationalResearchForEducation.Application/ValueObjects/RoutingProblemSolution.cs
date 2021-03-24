using System.Collections.Generic;

namespace thiagomotadev.OperationalResearchForEducation.Application.ValueObjects
{
    public class RoutingProblemSolution
    {
        public IList<int> Route { get; set; }

        public long Distance { get; set; }

        public FirstSolutionStrategy FirstSolutionStrategy { get; set; }

        public RoutingProblemSolution()
        {
            this.Route = new List<int>();
        }
    }
}
