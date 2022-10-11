import { EditStudentComponent } from './edit-student/edit-student.component';
import { AddStudentComponent } from './add-student/add-student.component';
import { StudentComponent } from './student.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'list',
    pathMatch: 'full',
  },
  {
    path: 'list',
    component: StudentComponent,
  },
  {
    path: 'add',
    component: AddStudentComponent,
  },
  {
    path: 'edit/:id',
    component: EditStudentComponent,
  },
];

export const StudentRoutes = RouterModule.forChild(routes);
