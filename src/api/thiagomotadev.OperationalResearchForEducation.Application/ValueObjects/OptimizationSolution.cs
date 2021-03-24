using System.Collections.Generic;

namespace thiagomotadev.OperationalResearchForEducation.Application.ValueObjects
{
    public class OptimizationSolution
    {
        public int Result { get; set; }

        public List<Variable> Variables { get; set; }

        public OptimizationSolution()
        {
            Variables = new List<Variable>();
        }
    }

    public class Variable
    {
        public string Name { get; set; }

        public int Value { get; set; }
    }
}
