import { Menu } from './shared/interfaces/Menu';
import { CommonService } from './shared/services/common.service';
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

  constructor(private translate: TranslateService) {
    const token = localStorage.getItem('token');
    const lang = localStorage.getItem('language') ?? 'ar';
    this.isLoggedIn = token != null && token != '';

    translate.setDefaultLang('ar');
    translate.use(lang);
  }

  ngAfterViewInit(): void {}
  ngOnInit(): void {}

  title = 'Zade Akademi';
}
