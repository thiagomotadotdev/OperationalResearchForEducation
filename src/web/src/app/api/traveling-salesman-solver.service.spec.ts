import { TestBed } from '@angular/core/testing';

import { TravelingSalesmanSolverService } from './traveling-salesman-solver.service';

describe('TravelingSalesmanSolverService', () => {
  let service: TravelingSalesmanSolverService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TravelingSalesmanSolverService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
