import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { OptimizerComponent } from './optimizer.component';
import { OnlyExpressionsComponent } from './only-expressions/only-expressions.component';

const routes: Routes = [
  {
    path: '',
    component: OptimizerComponent,
    children: [
      { path: 'only-expressions', component: OnlyExpressionsComponent },
      { path: '', redirectTo: 'only-expressions', pathMatch: 'full' },
      { path: '**', redirectTo: 'only-expressions' },
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LinearProgrammingRoutingModule { }
