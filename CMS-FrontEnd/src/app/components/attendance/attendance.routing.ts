import { AddAttendanceComponent } from './add-attendance/add-attendance.component';
import { AttendanceComponent } from './attendance.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'list',
    pathMatch: 'full',
  },
  {
    path: 'list',
    component: AttendanceComponent,
  },
  {
    path: 'add',
    component: AddAttendanceComponent,
  },
];

export const AttendanceRoutes = RouterModule.forChild(routes);
