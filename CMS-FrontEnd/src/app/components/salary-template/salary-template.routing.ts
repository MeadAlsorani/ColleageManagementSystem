import { AddLoanComponent } from './loan/add-loan/add-loan.component';
import { EditSalaryTemplateComponent } from './edit-salary-template/edit-salary-template.component';
import { AddSalaryTemplateComponent } from './add-salary-template/add-salary-template.component';
import { SalaryTemplateComponent } from './salary-template.component';
import { Routes, RouterModule } from '@angular/router';
import { LoansListComponent } from './loan/loans-list/loans-list.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'list',
    pathMatch: 'full',
  },
  {
    path: 'list',
    component: SalaryTemplateComponent,
  },
  {
    path: 'add',
    component: AddSalaryTemplateComponent,
  },
  {
    path: 'edit/:id',
    component: EditSalaryTemplateComponent,
  },
  {
    path: ':id/loans',
    component: LoansListComponent,
  },
  {
    path: ':id/add',
    component: AddLoanComponent,
  },
];

export const SalaryTemplateRoutes = RouterModule.forChild(routes);
