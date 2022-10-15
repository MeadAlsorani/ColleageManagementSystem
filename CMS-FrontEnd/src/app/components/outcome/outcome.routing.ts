import { EditOutcomeComponent } from './edit-outcome/edit-outcome.component';
import { AddOutcomeComponent } from './add-outcome/add-outcome.component';
import { OutcomeComponent } from './outcome.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'list',
    pathMatch: 'full',
  },
  {
    path: 'list',
    component: OutcomeComponent,
  },
  {
    path: 'add',
    component: AddOutcomeComponent,
  },
  {
    path: 'edit/:id',
    component: EditOutcomeComponent,
  },
];

export const OutcomeRoutes = RouterModule.forChild(routes);
