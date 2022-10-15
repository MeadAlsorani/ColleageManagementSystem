import { OutcomeService } from './shared/outcome.service';
import { OutcomeRoutes } from './outcome.routing';
import { SharedModule } from './../../shared/sharedModule.module';
import { EditOutcomeComponent } from './edit-outcome/edit-outcome.component';
import { AddOutcomeComponent } from './add-outcome/add-outcome.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OutcomeComponent } from './outcome.component';

@NgModule({
  imports: [CommonModule, SharedModule, OutcomeRoutes],
  declarations: [OutcomeComponent, AddOutcomeComponent, EditOutcomeComponent],
  providers: [OutcomeService],
})
export class OutcomeModule {}
