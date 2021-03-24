import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatButtonModule } from '@angular/material/button';

import { NavbarComponent } from './navbar/navbar.component';
import { SecondaryNavbarComponent } from './secondary-navbar/secondary-navbar.component';

@NgModule({
  declarations: [NavbarComponent, SecondaryNavbarComponent],
  imports: [
    CommonModule,
    RouterModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule
  ],
  exports: [
    NavbarComponent,
    SecondaryNavbarComponent
  ]
})
export class ComponentsModule { }
