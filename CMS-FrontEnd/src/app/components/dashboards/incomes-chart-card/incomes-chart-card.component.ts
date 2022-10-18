import { tap } from 'rxjs';
import { DashboardService } from './../shared/dashboard.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';

@Component({
  selector: 'app-incomes-chart-card',
  templateUrl: './incomes-chart-card.component.html',
  styleUrls: ['./incomes-chart-card.component.less'],
})
export class IncomesChartCardComponent extends BaseComponent implements OnInit {
  showXAxis = true;
  showYAxis = true;
  gradient = false;
  showLegend = true;
  showXAxisLabel = true;
  showYAxisLabel = true;
  total: number = 0;
  multi: any[] = [];
  single: { name: string; value: number }[] = [];
  colorScheme: any = {
    domain: ['#5AA454', '#3a0aa1', '#C7B42C', '#AAAAAA'],
  };
  constructor(injector: Injector, private dashboardService: DashboardService) {
    super(injector);
  }

  ngOnInit() {
    this.dashboardService
      .getIncomes()
      .pipe(
        tap((response: any) => {
          Object.keys(response).forEach((key: string) => {
            this.single = [...this.single, { name: key, value: response[key] }];
            this.total += response[key];
          });
        })
      )
      .subscribe();
  }
  onSelect(event: any) {
    console.log(event);
  }
}
