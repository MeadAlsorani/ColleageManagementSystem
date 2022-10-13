import { EditStaffComponent } from './edit-staff/edit-staff.component';
import { AddStaffComponent } from './add-staff/add-staff.component';
import { StaffComponent } from './staff.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'list',
    pathMatch: 'fulll',
  },
  {
    path: 'list',
    component: StaffComponent,
  },
  {
    path: 'add',
    component: AddStaffComponent,
  },
  {
    path: 'edit/:id',
    component: EditStaffComponent,
  },
];

export const StaffRoutes = RouterModule.forChild(routes);
