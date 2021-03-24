import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DistanceMatrixComponent } from './distance-matrix/distance-matrix.component';
import { ParametersComponent } from './parameters/parameters.component';
import { TravelingSalesmanComponent } from './traveling-salesman.component';

const routes: Routes = [
  {
    path: '',
    component: TravelingSalesmanComponent,
    children: [
      { path: 'parameters', component: ParametersComponent },
      { path: 'distance-matrix', component: DistanceMatrixComponent },
      { path: '', redirectTo: 'parameters', pathMatch: 'full' },
      { path: '**', redirectTo: 'parameters' },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TravelingSalesmanRoutingModule { }
