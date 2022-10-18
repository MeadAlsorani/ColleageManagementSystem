import { DashboardService } from './../shared/dashboard.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-attendance-chart',
  templateUrl: './attendance-chart.component.html',
  styleUrls: ['./attendance-chart.component.less'],
})
export class AttendanceChartComponent implements OnInit {
  single: any[] = [];
  view: any[] = [700, 400];

  // options
  gradient: boolean = true;
  showLegend: boolean = true;
  showLabels: boolean = true;
  isDoughnut: boolean = false;

  colorScheme: any = {
    domain: ['#5AA454', '#A10A28', '#C7B42C', '#AAAAAA'],
  };

  constructor(private dashboardService: DashboardService) {}
  ngOnInit(): void {
    this.dashboardService.getAttendanceCounts().subscribe((response: any) => {
      console.log(response);
      // this.single = [
      //   {
      //     name: 'students',
      //     value: response.students,
      //   },
      //   {
      //     name: 'staffs',
      //     value: response.staffs,
      //   },
      // ];
    });
  }
  onSelect(data: any): void {
    console.log('Item clicked', JSON.parse(JSON.stringify(data)));
  }

  onActivate(data: any): void {
    console.log('Activate', JSON.parse(JSON.stringify(data)));
  }

  onDeactivate(data: any): void {
    console.log('Deactivate', JSON.parse(JSON.stringify(data)));
  }
}
