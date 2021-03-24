import { Component, Input, OnInit } from '@angular/core';

import { NavbarItem } from './navbar-item';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  @Input() public items: NavbarItem[];

  constructor() {
    this.items = [];
  }

  ngOnInit(): void {
  }

}
