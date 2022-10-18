import { AttendanceChartComponent } from './attendance-chart/attendance-chart.component';
import { OutcomesChartCardComponent } from './outcomes-chart-card/outcomes-chart-card.component';
import { IncomesChartCardComponent } from './incomes-chart-card/incomes-chart-card.component';
import { CountsCardComponent } from './counts-card/counts-card.component';
import { CalendarComponent } from './calendar/calendar.component';
import { SharedModule } from './../../shared/sharedModule.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { HomeComponent } from './home/home.component';
import { Route, RouterModule } from '@angular/router';
import { NgxChartsModule } from '@swimlane/ngx-charts';
const routes: Route[] = [
  {
    path: '',
    component: HomeComponent,
  },
];
@NgModule({
  imports: [
    CommonModule,
    SharedModule,
    NgxChartsModule,
    RouterModule.forChild(routes),
    CalendarModule.forRoot({
      provide: DateAdapter,
      useFactory: adapterFactory,
    }),
  ],
  declarations: [
    CalendarComponent,
    HomeComponent,
    CountsCardComponent,
    IncomesChartCardComponent,
    OutcomesChartCardComponent,
    AttendanceChartComponent,
  ],
})
export class DashboardsModule {}
