import { StaffService } from './shared/staff.service';
import { SharedModule } from './../../shared/sharedModule.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StaffComponent } from './staff.component';
import { AddStaffComponent } from './add-staff/add-staff.component';
import { EditStaffComponent } from './edit-staff/edit-staff.component';
import { StaffRoutes } from './staff.routing';

@NgModule({
  imports: [CommonModule, SharedModule, StaffRoutes],
  declarations: [StaffComponent, AddStaffComponent, EditStaffComponent],
  providers: [StaffService],
})
export class StaffModule {}
