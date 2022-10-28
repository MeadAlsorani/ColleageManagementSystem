import { CoursesBalanceComponent } from './shared/courses-balance/courses-balance.component';
import { AttendanceDialogComponent } from './shared/attendance-dialog/attendance-dialog.component';
import { EditStudentComponent } from './edit-student/edit-student.component';
import { AddStudentComponent } from './add-student/add-student.component';
import { StudentService } from './shared/student.service';
import { SharedModule } from './../../shared/sharedModule.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentComponent } from './student.component';
import { StudentRoutes } from './student.routing';
@NgModule({
  imports: [CommonModule, SharedModule, StudentRoutes],
  declarations: [
    StudentComponent,
    AddStudentComponent,
    EditStudentComponent,
    CoursesBalanceComponent,
  ],
  providers: [StudentService],
})
export class StudentModule {}
