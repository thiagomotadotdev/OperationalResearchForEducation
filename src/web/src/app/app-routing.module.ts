import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { WebModule } from './web/web.module';

const routes: Routes = [
  {
    path: '',
    component: AppComponent,
    children: [
      { path: 'web', loadChildren: () => WebModule },
      { path: '', redirectTo: 'web', pathMatch: 'full' },
      { path: '**', redirectTo: 'web' },
    ]
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
