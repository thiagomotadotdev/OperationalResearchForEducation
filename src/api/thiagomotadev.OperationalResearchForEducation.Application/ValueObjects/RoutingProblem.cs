using System.Collections.Generic;

namespace thiagomotadev.OperationalResearchForEducation.Application.ValueObjects
{
    public class RoutingProblem
    {
        public DistanceMatrix DistanceMatrix { get; set; }
        public int NumberOfPoints { get; set; }
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
        public FirstSolutionStrategy FirstSolutionStrategy { get; set; }
    }

    public class DistanceMatrix
    {
        public IList<DistanceArray> DistanceArrays;

        public DistanceMatrix()
        {
            DistanceArrays = new List<DistanceArray>();
        }

        public double GetDistance(int rowIndex, int columnIndex)
        {
            return this.DistanceArrays[rowIndex].GetDistance(columnIndex);
        }

        public int GetSize()
        {
            return this.DistanceArrays.Count;
        }
    }

    public class DistanceArray
    {
        public IList<double> Distances { get; set; }

        public DistanceArray()
        {
            Distances = new List<double>();
        }

        public double GetDistance(int index)
        {
            return this.Distances[index];
        }
    }
}
