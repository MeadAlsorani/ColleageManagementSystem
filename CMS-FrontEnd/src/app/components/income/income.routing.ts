import { EditIncomeComponent } from './edit-income/edit-income.component';
import { AddIncomeComponent } from './add-income/add-income.component';
import { IncomeComponent } from './income.component';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'list',
    pathMatch: 'full',
  },
  {
    path: 'list',
    component: IncomeComponent,
  },
  {
    path: 'add',
    component: AddIncomeComponent,
  },
  {
    path: 'edit/:id',
    component: EditIncomeComponent,
  },
];

export const IncomeRoutes = RouterModule.forChild(routes);
