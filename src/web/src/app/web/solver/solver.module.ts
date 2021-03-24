import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';

import { SolverRoutingModule } from './solver-routing.module';
import { SolverComponent } from './solver.component';

@NgModule({
  declarations: [SolverComponent],
  imports: [
    CommonModule,
    SolverRoutingModule,
    MatToolbarModule,
    MatButtonModule
  ]
})
export class SolverModule { }
