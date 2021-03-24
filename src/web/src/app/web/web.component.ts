import { Component, OnInit } from '@angular/core';
import { NavbarItem } from '../components/navbar/navbar-item';

@Component({
  selector: 'app-web',
  templateUrl: './web.component.html',
  styleUrls: ['./web.component.scss']
})
export class WebComponent implements OnInit {

  public navbarItems: NavbarItem[];

  constructor() {
    this.navbarItems = [
      {Name: 'Linear Programming', Route: './linear-programming'}
    ];
  }

  ngOnInit(): void {
  }

}
