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
  @ViewChild('snav') drawer!: MatDrawer;
  mobileQuery!: MediaQueryList;
  constructor(media: MediaMatcher, private translate: TranslateService) {
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
    translate.setDefaultLang('ar');
    translate.use('ar');
  }

  ngAfterViewInit(): void {
    console.log(this.drawer);
    this.drawer.open();
  }
  ngOnInit(): void {}
  title = 'CMS-FrontEnd';
}
