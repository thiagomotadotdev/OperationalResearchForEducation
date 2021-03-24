import { TestBed } from '@angular/core/testing';

import { OptimizerService } from './optimizer.service';

describe('LinearProgrammingSolverService', () => {
  let service: OptimizerService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(OptimizerService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
