namespace thiagomotadev.OperationalResearchForEducation.Application.ValueObjects
{
    public class LinearSolveType : CustomizedEnum
    {
        public static readonly LinearSolveType Unset = new LinearSolveType(0, "Unset");
        public static readonly LinearSolveType Minimize = new LinearSolveType(1, "Minimize");
        public static readonly LinearSolveType Maximize = new LinearSolveType(2, "Maximize");

        public LinearSolveType() { }

        protected LinearSolveType(int code, string name) : base(code, name) { }
    }
}
