import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LinearProgrammingRoutingModule } from './optimizer-routing.module';
import { OptimizerComponent } from './optimizer.component';
import { OnlyExpressionsComponent } from './only-expressions/only-expressions.component';
import { ComponentsModule } from 'src/app/components/components.module';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatSelectModule } from '@angular/material/select';
import { ReactiveFormsModule } from '@angular/forms';
import { ApiModule } from '../../api/api.module';


@NgModule({
  declarations: [OptimizerComponent, OnlyExpressionsComponent],
  imports: [
    CommonModule,
    LinearProgrammingRoutingModule,
    ComponentsModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule,
    MatIconModule,
    ReactiveFormsModule,
    MatSelectModule,
    ApiModule
  ]
})
export class OptimizerModule { }
