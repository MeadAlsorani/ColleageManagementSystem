import { DashboardService } from './../shared/dashboard.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';

@Component({
  selector: 'app-counts-card',
  templateUrl: './counts-card.component.html',
  styleUrls: ['./counts-card.component.less'],
})
export class CountsCardComponent extends BaseComponent implements OnInit {
  studentsCount: number = 0;
  staffsCount: number = 0;
  constructor(injector: Injector, private dashboardService: DashboardService) {
    super(injector);
  }

  ngOnInit() {
    this.dashboardService.getCounts().subscribe((response: any) => {
      this.studentsCount = response.studentCount;
      this.staffsCount = response.staffCount;
    });
  }
}
