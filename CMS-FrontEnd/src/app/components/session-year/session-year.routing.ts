import { EditSessionYearComponent } from './edit-session-year/edit-session-year.component';
import { AddSessionYearComponent } from './add-session-year/add-session-year.component';
import { SessionYearComponent } from './session-year.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'list',
    pathMatch: 'full',
  },
  {
    path: 'list',
    component: SessionYearComponent,
  },
  {
    path: 'add',
    component: AddSessionYearComponent,
  },
  {
    path: 'edit/:id',
    component: EditSessionYearComponent,
  },
];

export const SessionYearRoutes = RouterModule.forChild(routes);
