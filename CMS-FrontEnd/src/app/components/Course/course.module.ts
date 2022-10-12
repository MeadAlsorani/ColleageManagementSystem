import { CourseService } from './shared/course.service';
import { CourseRoutes } from './course.routing';
import { EditCourseComponent } from './edit-course/edit-course.component';
import { AddCourseComponent } from './add-course/add-course.component';
import { SharedModule } from 'src/app/shared/sharedModule.module';
import { CoursesComponent } from './courses/courses.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [CommonModule, SharedModule, CourseRoutes],
  declarations: [CoursesComponent, AddCourseComponent, EditCourseComponent],
  providers: [CourseService],
})
export class CourseModule {}
