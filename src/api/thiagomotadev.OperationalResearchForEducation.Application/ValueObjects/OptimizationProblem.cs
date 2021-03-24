using System.Collections.Generic;

namespace thiagomotadev.OperationalResearchForEducation.Application.ValueObjects
{
    public class OptimizationProblem
    {
        public static List<OptimizationProblem> Examples = new List<OptimizationProblem>
        {
            new OptimizationProblem{
                Variables = new List<string>{"x1","x2"},
                RestrictionExpressions = new List<string>
                {
                    "2 * x1 + 5 * x2 <= 20",
                    "5 * x1 + 3 * x2 <= 30"
                },
                SolveType = LinearSolveType.Maximize,
                ObjectiveExpression = "2 * x1 + 3 * x2"
            },
            new OptimizationProblem{
                Variables = new List<string>{"x1","x2"},
                RestrictionExpressions = new List<string>
                {
                    "x1 + 4 * x2 >= 5",
                    "3 * x1 + 2 * x2 >= 7"
                },
                SolveType = LinearSolveType.Minimize,
                ObjectiveExpression = "4 * x1 + 5 * x2"
            },
            // livro exemplo 5.1
            new OptimizationProblem{
                Variables = new List<string>{"x11","x12","x13","x21","x22","x23","x31","x32","x33"},
                RestrictionExpressions = new List<string>
                {
                    "x11 + x12 + x13 == 100",
                    "x21 + x22 + x23 == 140",
                    "x31 + x32 + x33 == 160",
                    "x11 + x21 + x31 == 120",
                    "x12 + x22 + x32 == 130",
                    "x13 + x23 + x33 == 150",
                },
                SolveType = LinearSolveType.Minimize,
                ObjectiveExpression = "12 * x11 + 22 * x12 + 30 * x13 + 18 * x21 + 24 * x22 + 32 * x23 + 22 * x31 + 15 * x32 + 34 * x33"
            },
            // livro exemplo 5.2
            new OptimizationProblem{
                Variables = new List<string>{"x11","x12","x13","x21","x22","x23","x31","x32","x33"},
                RestrictionExpressions = new List<string>
                {
                    "x11 + x12 + x13 <= 50",
                    "x21 + x22 + x23 <= 100",
                    "x31 + x32 + x33 <= 40",
                    "x11 + x21 + x31 >= 60",
                    "x12 + x22 + x32 >= 70",
                    "x13 + x23 + x33 >= 30",
                },
                SolveType = LinearSolveType.Minimize,
                ObjectiveExpression = "8 * x11 + 12 * x12 + 10 * x13 + 4 * x21 + 10 * x22 + 6 * x23 + 6 * x31 + 15 * x32 + 12 * x33"
            },
            // livro exemplo 5.3
            new OptimizationProblem{
                Variables = new List<string>{"x11","x12","x13","x21","x22","x23","x31","x32","x33"},
                RestrictionExpressions = new List<string>
                {
                    "x11 + x12 + x13 == 60",
                    "x21 + x22 + x23 == 40",
                    "x31 + x32 + x33 == 50",
                    "x11 + x21 + x31 <= 50",
                    "x12 + x22 + x32 <= 120",
                    "x13 + x23 + x33 <= 80",
                },
                SolveType = LinearSolveType.Minimize,
                ObjectiveExpression = "8 * x11 + 12 * x12 + 10 * x13 + 4 * x21 + 10 * x22 + 6 * x23 + 6 * x31 + 15 * x32 + 12 * x33"
            },
            // livro 6.2 2
            new OptimizationProblem{
                Variables = new List<string>{"x1","x2"},
                RestrictionExpressions = new List<string>
                {
                    "2 * x1 + 5 * x2 <= 20",
                    "5 * x1 + 3 * x2 <= 30"
                },
                SolveType = LinearSolveType.Maximize,
                ObjectiveExpression = "2 * x1 + 3 * x2"
            },
            // livro 6.2 3
            new OptimizationProblem{
                Variables = new List<string>{"x1","x2"},
                RestrictionExpressions = new List<string>
                {
                    "x1 + 3 * x2 <= 6",
                    "3 * x1 + x2 <= 9"
                },
                SolveType = LinearSolveType.Maximize,
                ObjectiveExpression = "x1 + 2 * x2"
            },
            // livro exemplo 6.10
            new OptimizationProblem{
                Variables = new List<string>{"y1 bool","y2 bool","y3 bool","y4 bool","y5 bool",
                                             "x11","x12","x13","x14","x15",
                                             "x21","x22","x23","x24","x25",
                                             "x31","x32","x33","x34","x35",
                                             "x41","x42","x43","x44","x45",
                                             "x51","x52","x53","x54","x55"},
                RestrictionExpressions = new List<string>
                {
                    "x11 + x12 + x13 + x14 + x15 <= 35000 * y1",
                    "x21 + x22 + x23 + x24 + x25 <= 30000 * y2",
                    "x31 + x32 + x33 + x34 + x35 <= 25000 * y3",
                    "x41 + x42 + x43 + x44 + x45 <= 30000 * y4",
                    "x51 + x52 + x53 + x54 + x55 <= 20000 * y5",
                    "x11 + x21 + x31 + x41 + x51 == 16000",
                    "x12 + x22 + x32 + x42 + x52 == 18000",
                    "x13 + x23 + x33 + x43 + x53 == 12000",
                    "x14 + x24 + x34 + x44 + x54 == 17000",
                    "x15 + x25 + x35 + x45 + x55 == 20000"
                },
                SolveType = LinearSolveType.Minimize,
                ObjectiveExpression = "111000 * y1 + 124000 * y2 + 120000 * y3 + 135000 * y4 + 140000 * y5 + " +
                                      "0.82 * x11 + 0.95 * x12 + 1.10 * x13 + 1.33 * x14 + 1.22 * x15 + " +
                                      "0.74 * x21 + 1.12 * x22 + 1.06 * x23 + 1.13 * x24 + 1.24 * x25 + " +
                                      "1.34 * x31 + 1.24 * x32 + 0.72 * x33 + 0.72 * x34 + 0.88 * x35 + " +
                                      "1.48 * x41 + 1.26 * x42 + 0.98 * x43 + 0.95 * x44 + 0.70 * x45 + " +
                                      "1.52 * x51 + 1.45 * x52 + 1.33 * x53 + 1.22 * x54 + 1.15 * x55"
            },
            // livro exemplo 6.10
            new OptimizationProblem{
                Variables = new List<string>{"x1","x2","x3","x4","x5","x6","x7"},
                RestrictionExpressions = new List<string>
                {
                    "x11 + x12 + x13 + x14 + x15 <= 35000 * y1",
                    "x21 + x22 + x23 + x24 + x25 <= 30000 * y2",
                    "x31 + x32 + x33 + x34 + x35 <= 25000 * y3",
                    "x41 + x42 + x43 + x44 + x45 <= 30000 * y4",
                    "x51 + x52 + x53 + x54 + x55 <= 20000 * y5",
                    "x11 + x21 + x31 + x41 + x51 == 16000",
                    "x12 + x22 + x32 + x42 + x52 == 18000",
                    "x13 + x23 + x33 + x43 + x53 == 12000",
                    "x14 + x24 + x34 + x44 + x54 == 17000",
                    "x15 + x25 + x35 + x45 + x55 == 20000"
                },
                SolveType = LinearSolveType.Minimize,
                ObjectiveExpression = "111000 * y1 + 124000 * y2 + 120000 * y3 + 135000 * y4 + 140000 * y5 + " +
                                      "0.82 * x11 + 0.95 * x12 + 1.10 * x13 + 1.33 * x14 + 1.22 * x15 + " +
                                      "0.74 * x21 + 1.12 * x22 + 1.06 * x23 + 1.13 * x24 + 1.24 * x25 + " +
                                      "1.34 * x31 + 1.24 * x32 + 0.72 * x33 + 0.72 * x34 + 0.88 * x35 + " +
                                      "1.48 * x41 + 1.26 * x42 + 0.98 * x43 + 0.95 * x44 + 0.70 * x45 + " +
                                      "1.52 * x51 + 1.45 * x52 + 1.33 * x53 + 1.22 * x54 + 1.15 * x55"
            },
        };

        public List<string> Variables { get; set; }

        public List<string> RestrictionExpressions { get; set; }

        public LinearSolveType SolveType { get; set; }

        public string ObjectiveExpression { get; set; }

        public OptimizationProblem()
        {
            Variables = new List<string>();
        }
    }
}
