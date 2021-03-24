import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SolverComponent } from './solver.component';
import { TravelingSalesmanModule } from './traveling-salesman/traveling-salesman.module';

const routes: Routes = [
  {
    path: '',
    component: SolverComponent,
    children: [
      { path: 'traveling-salesman', loadChildren: () => TravelingSalesmanModule },
      { path: '', redirectTo: 'traveling-salesman', pathMatch: 'full' },
      { path: '**', redirectTo: 'traveling-salesman' },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SolverRoutingModule { }
