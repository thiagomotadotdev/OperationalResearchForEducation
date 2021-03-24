namespace thiagomotadev.OperationalResearchForEducation.Application.ValueObjects
{


    public class FirstSolutionStrategy : CustomizedEnum
    {
        public static readonly FirstSolutionStrategy Unset = new FirstSolutionStrategy(0, "");
        public static readonly FirstSolutionStrategy GlobalCheapestArc = new FirstSolutionStrategy(1, "GlobalCheapestArc");
        public static readonly FirstSolutionStrategy LocalCheapestArc = new FirstSolutionStrategy(2, "LocalCheapestArc");
        public static readonly FirstSolutionStrategy PathCheapestArc = new FirstSolutionStrategy(3, "PathCheapestArc");
        public static readonly FirstSolutionStrategy PathMostConstrainedArc = new FirstSolutionStrategy(4, "PathMostConstrainedArc");
        //public static readonly FirstSolutionStrategy EvaluatorStrategy = new FirstSolutionStrategy(5, "EvaluatorStrategy");
        //public static readonly FirstSolutionStrategy AllUnperformed = new FirstSolutionStrategy(6, "AllUnperformed");
        //public static readonly FirstSolutionStrategy BestInsertion = new FirstSolutionStrategy(7, "BestInsertion");
        public static readonly FirstSolutionStrategy ParallelCheapestInsertion = new FirstSolutionStrategy(8, "ParallelCheapestInsertion");
        public static readonly FirstSolutionStrategy LocalCheapestInsertion = new FirstSolutionStrategy(9, "LocalCheapestInsertion");
        public static readonly FirstSolutionStrategy Savings = new FirstSolutionStrategy(10, "Savings");
        //public static readonly FirstSolutionStrategy Sweep = new FirstSolutionStrategy(11, "Sweep");
        public static readonly FirstSolutionStrategy FirstUnboundMinValue = new FirstSolutionStrategy(12, "FirstUnboundMinValue");
        public static readonly FirstSolutionStrategy Christofides = new FirstSolutionStrategy(13, "Christofides");
        public static readonly FirstSolutionStrategy SequentialCheapestInsertion = new FirstSolutionStrategy(14, "SequentialCheapestInsertion");
        public static readonly FirstSolutionStrategy Automatic = new FirstSolutionStrategy(15, "Automatic");

        public FirstSolutionStrategy() { }

        protected FirstSolutionStrategy(int code, string name) : base(code, name) { }
    }
}
