import { Variable } from './variable';

export interface OptimizerSolution {
    result: number;
    variables: Variable[];
}
