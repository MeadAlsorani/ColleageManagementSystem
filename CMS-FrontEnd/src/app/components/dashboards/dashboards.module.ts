import { CalendarComponent } from './calendar/calendar.component';
import { SharedModule } from './../../shared/sharedModule.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CalendarModule, DateAdapter } from 'angular-calendar';
import { adapterFactory } from 'angular-calendar/date-adapters/date-fns';
import { HomeComponent } from './home/home.component';
import { Route, RouterModule } from '@angular/router';
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
    RouterModule.forChild(routes),
    CalendarModule.forRoot({
      provide: DateAdapter,
      useFactory: adapterFactory,
    }),
  ],
  declarations: [CalendarComponent, HomeComponent],
})
export class DashboardsModule {}
