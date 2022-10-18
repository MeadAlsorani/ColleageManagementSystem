import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/shared/interfaces/User';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.less'],
})
export class HomeComponent implements OnInit {
  role: string = '';
  constructor() {}

  ngOnInit() {
    const user: User = JSON.parse(localStorage.getItem('userData') ?? '');
    this.role = user.role;
  }
}
