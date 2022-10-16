import { LoansListComponent } from './loan/loans-list/loans-list.component';
import { SalaryTemplateRoutes } from './salary-template.routing';
import { SharedModule } from 'src/app/shared/sharedModule.module';
import { SalaryTemplateService } from './shared/salary-template.service';
import { EditSalaryTemplateComponent } from './edit-salary-template/edit-salary-template.component';
import { AddSalaryTemplateComponent } from './add-salary-template/add-salary-template.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SalaryTemplateComponent } from './salary-template.component';
import { AddLoanComponent } from './loan/add-loan/add-loan.component';

@NgModule({
  imports: [CommonModule, SharedModule, SalaryTemplateRoutes],
  declarations: [
    SalaryTemplateComponent,
    AddSalaryTemplateComponent,
    EditSalaryTemplateComponent,
    LoansListComponent,
    AddLoanComponent,
  ],
  providers: [SalaryTemplateService],
})
export class SalaryTemplateModule {}
