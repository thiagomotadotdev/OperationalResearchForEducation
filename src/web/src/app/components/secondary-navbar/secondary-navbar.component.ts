import { Component, Input, OnInit } from '@angular/core';
import { NavbarItem } from '../navbar/navbar-item';

@Component({
  selector: 'app-secondary-navbar',
  templateUrl: './secondary-navbar.component.html',
  styleUrls: ['./secondary-navbar.component.scss']
})
export class SecondaryNavbarComponent implements OnInit {

  @Input() public items: NavbarItem[];

  constructor() {
    this.items = [];
  }

  ngOnInit(): void {
  }

}
