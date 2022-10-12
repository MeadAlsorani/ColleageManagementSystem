import { CourseService } from './../shared/course.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';
import { concat, switchMap, tap } from 'rxjs';

@Component({
  selector: 'app-add-course',
  templateUrl: './add-course.component.html',
  styleUrls: ['./add-course.component.css'],
})
export class AddCourseComponent extends BaseComponent implements OnInit {
  fields: FormField[] = [
    {
      code: 'name',
      label: 'Name',
      required: true,
      type: FormFieldType.string,
    },
    {
      code: 'teacherId',
      label: 'Teacher',
      required: true,
      type: FormFieldType.dropdown,
      options: [],
    },
    {
      code: 'classId',
      label: 'Class',
      required: true,
      type: FormFieldType.dropdown,
      options: [],
    },
    {
      code: 'lessonDuration',
      label: 'Lesson Duration',
      required: true,
      type: FormFieldType.number,
    },
    {
      code: 'startDate',
      label: 'Start Date',
      required: true,
      type: FormFieldType.date,
    },
    {
      code: 'endDate',
      label: 'End Date',
      required: true,
      type: FormFieldType.date,
    },
    {
      code: 'price',
      label: 'Price',
      required: true,
      type: FormFieldType.number,
    },
  ];
  constructor(injector: Injector, private courseService: CourseService) {
    super(injector);
  }

  ngOnInit() {
    this.getOptions();
  }
  getOptions() {
    this.courseService
      .getTeachers()
      .pipe(
        tap((response) => {
          this.fields.find((x) => x.code == 'teacherId')!.options = response;
        }),
        switchMap(() => this.courseService.getClassesList()),
        tap((resp: { id: number; name: string }[]) => {
          this.fields.find((x) => x.code === 'classId')!.options = resp.map(
            (x) => {
              return { code: x.id, label: x.name };
            }
          );
        })
      )
      .subscribe();
  }
  submit(data: any) {
    this.courseService.Post(data).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../list'], { relativeTo: this.route });
    });
  }
}
