import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MatCardModule } from '@angular/material/card';

import { TravelingSalesmanRoutingModule } from './traveling-salesman-routing.module';
import { TravelingSalesmanComponent } from './traveling-salesman.component';
import { ParametersComponent } from './parameters/parameters.component';
import { DistanceMatrixComponent } from './distance-matrix/distance-matrix.component';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { ApiModule } from 'src/app/api/api.module';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    TravelingSalesmanComponent,
    ParametersComponent,
    DistanceMatrixComponent
  ],
  imports: [
    CommonModule,
    TravelingSalesmanRoutingModule,
    MatCardModule,
    MatIconModule,
    MatButtonModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    ApiModule,
    ReactiveFormsModule
  ],
})
export class TravelingSalesmanModule { }
