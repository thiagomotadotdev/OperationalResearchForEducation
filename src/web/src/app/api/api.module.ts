import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TravelingSalesmanSolverService } from './traveling-salesman-solver.service'
import { HttpClientModule } from '@angular/common/http';
import { OptimizerService } from './optimizer.service';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    HttpClientModule
  ],
  providers: [
    TravelingSalesmanSolverService,
    OptimizerService
  ]
})
export class ApiModule { }
