import { EditAttendanceComponent } from './edit-attendance/edit-attendance.component';
import { AddAttendanceComponent } from './add-attendance/add-attendance.component';
import { AttendanceService } from './shared/attendance.service';
import { SharedModule } from 'src/app/shared/sharedModule.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AttendanceComponent } from './attendance.component';
import { AttendanceRoutes } from './attendance.routing';
import { MAT_DIALOG_DATA, MatDialog } from '@angular/material/dialog';
import { DialogParams } from './shared/dialog-params';

@NgModule({
  imports: [CommonModule, SharedModule, AttendanceRoutes],
  declarations: [
    AttendanceComponent,
    AddAttendanceComponent,
    EditAttendanceComponent,
  ],
  providers: [
    AttendanceService,
    { provide: MAT_DIALOG_DATA, useClass: DialogParams },
  ],
})
export class AttendanceModule {}
