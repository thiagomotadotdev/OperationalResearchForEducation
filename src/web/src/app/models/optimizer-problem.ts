import { OptimizerSolveType } from './optimizer-solve-type';

export interface OptimizerProblem {
    variables: string[];
    restrictionExpressions: string[];
    solveType: OptimizerSolveType;
    objectiveExpression: string;
}
