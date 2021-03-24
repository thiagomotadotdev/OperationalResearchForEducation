import { Component, OnInit } from '@angular/core';
import { NavbarItem } from 'src/app/components/navbar/navbar-item';

@Component({
  selector: 'app-optimizer',
  templateUrl: './optimizer.component.html',
  styleUrls: ['./optimizer.component.scss']
})
export class OptimizerComponent implements OnInit {

  public navbarItems: NavbarItem[];

  constructor() {
    this.navbarItems = [
      {Name: 'Only Expressions', Route: './only-expressions'}
    ];
  }

  ngOnInit(): void {
  }

}
