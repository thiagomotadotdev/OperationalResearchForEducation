import { Injectable } from '@angular/core';
import { BaseService } from './base.service';
import { FirstSolutionStrategy } from '../models/first-solution-strategy';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TravelingSalesmanSolverService extends BaseService {

  protected getApiPath(): string {
    return '';
  }

  public getFirstSolutionStrategies(): Observable<FirstSolutionStrategy[]> {
    return this.get<FirstSolutionStrategy[]>('/default-values/first-solution-strategy');
  }

  public solve(request: any): Observable<any> {
    return this.post<any, any>('/routing-solvers/traveling-salesman-solver', request);
  }
}
