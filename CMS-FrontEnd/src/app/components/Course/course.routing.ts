import { EditCourseComponent } from './edit-course/edit-course.component';
import { AddCourseComponent } from './add-course/add-course.component';
import { CoursesComponent } from './courses/courses.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'list',
    pathMatch: 'full',
  },
  {
    path: 'list',
    component: CoursesComponent,
  },
  {
    path: 'add',
    component: AddCourseComponent,
  },
  {
    path: 'edit/:id',
    component: EditCourseComponent,
  },
];

export const CourseRoutes = RouterModule.forChild(routes);
