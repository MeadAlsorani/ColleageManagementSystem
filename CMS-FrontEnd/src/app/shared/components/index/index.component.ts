import { TranslateService } from '@ngx-translate/core';
import { CommonService } from './../../services/common.service';
import { AuthService } from './../../../components/Authentication/auth.service';
import { User } from './../../interfaces/User';
import { MediaMatcher } from '@angular/cdk/layout';
import { Component, OnInit, ViewChild, AfterViewInit } from '@angular/core';
import { MatDrawer } from '@angular/material/sidenav';
import { Menu } from '../../interfaces/Menu';

@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.less'],
})
export class IndexComponent implements OnInit, AfterViewInit {
  @ViewChild('snav') drawer!: MatDrawer;
  mobileQuery!: MediaQueryList;
  userData: User;
  menus: Menu[] = [];
  constructor(
    media: MediaMatcher,
    private authService: AuthService,
    private commonService: CommonService,
    private translateService: TranslateService
  ) {
    this.userData = authService.userData;
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
  }
  ngAfterViewInit(): void {
    setTimeout(() => {
      this.drawer.open();
    }, 1000);
    // this.userData = this.authService.userData;
  }
  getMenus() {
    this.commonService.getMenus().subscribe((response) => {
      this.menus = response;
      this.commonService.setMenus(response);
    });
  }
  ngOnInit() {
    this.getMenus();
  }
  logout() {
    this.authService.logOut();
  }
  changeLanguage(lang: string) {
    this.translateService.use(lang);
    localStorage.setItem('language', lang);
    window.location.reload();
  }
}
