import { Injectable } from '@angular/core';
import { BaseService } from './base.service';
import { OptimizerProblem } from '../models/optimizer-problem';
import { OptimizerSolution } from '../models/optimizer-solution';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class OptimizerService extends BaseService {

  protected getApiPath(): string {
    return '/optimizer';
  }

  public solveWithLinearOptimizer(request: OptimizerProblem): Observable<OptimizerSolution> {
    return this.post<OptimizerProblem, OptimizerSolution>('/linear/solve', request);
  }

  public solveWithIntegerOptimizer(request: OptimizerProblem): Observable<OptimizerSolution> {
    return this.post<OptimizerProblem, OptimizerSolution>('/integer/solve', request);
  }

  public getExamples(): Observable<OptimizerProblem[]> {
    return this.get<OptimizerProblem[]>('/solve');
  }

  public getExample(code: number): Observable<OptimizerProblem> {
    return this.get<OptimizerProblem>(`/example/${code}`);
  }
}
