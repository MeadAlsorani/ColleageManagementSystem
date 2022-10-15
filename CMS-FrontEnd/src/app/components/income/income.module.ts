import { IncomeService } from './shared/income.service';
import { SharedModule } from './../../shared/sharedModule.module';
import { EditIncomeComponent } from './edit-income/edit-income.component';
import { AddIncomeComponent } from './add-income/add-income.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { IncomeComponent } from './income.component';
import { IncomeRoutes } from './income.routing';

@NgModule({
  imports: [CommonModule, SharedModule, IncomeRoutes],
  declarations: [IncomeComponent, AddIncomeComponent, EditIncomeComponent],
  providers: [IncomeService],
})
export class IncomeModule {}
