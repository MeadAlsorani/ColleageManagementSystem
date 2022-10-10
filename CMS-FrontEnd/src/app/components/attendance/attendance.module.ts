import { EditAttendanceComponent } from './edit-attendance/edit-attendance.component';
import { AddAttendanceComponent } from './add-attendance/add-attendance.component';
import { AttendanceService } from './shared/attendance.service';
import { SharedModule } from 'src/app/shared/sharedModule.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AttendanceComponent } from './attendance.component';
import { AttendanceRoutes } from './attendance.routing';

@NgModule({
  imports: [CommonModule, SharedModule, AttendanceRoutes],
  declarations: [
    AttendanceComponent,
    AddAttendanceComponent,
    EditAttendanceComponent,
  ],
  providers: [AttendanceService],
})
export class AttendanceModule {}
