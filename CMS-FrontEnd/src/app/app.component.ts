import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MediaMatcher } from '@angular/cdk/layout';
import { MatDrawer } from '@angular/material/sidenav';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less'],
})
export class AppComponent implements OnInit, AfterViewInit {

  isLoggedIn: boolean;
  constructor( private translate: TranslateService) {
    const token = localStorage.getItem('token');
    this.isLoggedIn = token != null && token != '';

    translate.setDefaultLang('ar');
    translate.use('ar');
  }

  ngAfterViewInit(): void {

  }
  ngOnInit(): void {}
  title = 'Zade Akademi';
}
