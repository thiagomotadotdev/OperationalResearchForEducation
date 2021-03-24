import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SolverModule } from './solver/solver.module';
import { OptimizerModule } from './optimizer/optimizer.module';
import { WebComponent } from './web.component';

const routes: Routes = [
  {
    path: '',
    component: WebComponent,
    children: [
      { path: 'solver', loadChildren: () => SolverModule },
      { path: 'linear-programming', loadChildren: () => OptimizerModule },
      { path: '', redirectTo: 'solver', pathMatch: 'full' },
      { path: '**', redirectTo: 'solver' },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class WebRoutingModule { }
