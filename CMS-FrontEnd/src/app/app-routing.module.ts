import { AuthGuard } from './shared/guards/auth.guard';
import { IndexComponent } from './shared/components/index/index.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'app',
    pathMatch: 'full',
  },
  {
    path: 'auth',
    loadChildren: () =>
      import('./components/Authentication/auth.module').then(
        (x) => x.AuthModule
      ),
  },
  {
    path: 'app',
    component: IndexComponent,
    canActivate: [AuthGuard],
    children: [
      {
        path: 'announcements',
        loadChildren: () =>
          import('./components/Announcement/Announcement.module').then(
            (x) => x.AnnouncementModule
          ),
      },
      {
        path: 'attendances',
        loadChildren: () =>
          import('./components/attendance/attendance.module').then(
            (x) => x.AttendanceModule
          ),
      },
      {
        path: 'student',
        loadChildren: () =>
          import('./components/student/student.module').then(
            (x) => x.StudentModule
          ),
      },
      {
        path: 'course',
        loadChildren: () =>
          import('./components/Course/course.module').then(
            (x) => x.CourseModule
          ),
      },
      {
        path: 'session-year',
        loadChildren: () =>
          import('./components/session-year/session-year.module').then(
            (x) => x.SessionYearModule
          ),
      },
      {
        path: 'staff',
        loadChildren: () =>
          import('./components/staff/staff.module').then((x) => x.StaffModule),
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
