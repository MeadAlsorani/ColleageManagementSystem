import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MediaMatcher } from '@angular/cdk/layout';
import { MatDrawer } from '@angular/material/sidenav';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.less'],
})
export class AppComponent implements OnInit, AfterViewInit {
  @ViewChild('snav') drawer!: MatDrawer;
  mobileQuery!: MediaQueryList;
  constructor(media: MediaMatcher) {
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
  }
  ngAfterViewInit(): void {
    console.log(this.drawer);
    this.drawer.open();
  }
  ngOnInit(): void {}
  title = 'CMS-FrontEnd';
}
