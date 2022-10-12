import { tap, switchMap } from 'rxjs';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';
import { BaseComponent } from './../../../shared/components/Base.component';
import { CourseService } from './../shared/course.service';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';
import { Component, OnInit, Injector } from '@angular/core';
import { Action } from 'src/app/shared/interfaces/Table';

@Component({
  selector: 'app-edit-course',
  templateUrl: './edit-course.component.html',
  styleUrls: ['./edit-course.component.css'],
})
export class EditCourseComponent extends BaseComponent implements OnInit {
  fields: FormField[];
  selectedId: number = 0;
  formGroup: FormGroup;
  constructor(injector: Injector, private courseService: CourseService) {
    super(injector);
    this.fields = [
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

    this.formGroup = this.formBuilder.group({});
    this.fields.forEach((field) => {
      this.formGroup.addControl(
        field.code,
        new FormControl(null, field.required ? Validators.required : null)
      );
    });
  }

  ngOnInit() {
    this.getOptions();
    const route$ = this.route.params
      .pipe(
        tap((params) => {
          this.selectedId = params['id'];
        }),
        switchMap(() => this.getOptions()),
        switchMap(() => this.getCourse())
      )
      .subscribe();
    this.subscriptions.push(route$);
  }
  getCourse() {
    return this.courseService.GetDetails(this.selectedId).pipe(
      tap((response) => {
        this.formGroup.patchValue(response);
      })
    );
  }
  getOptions() {
    return this.courseService.getTeachers().pipe(
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
    );
  }
  submit(data: any) {
    data.id = this.selectedId;
    this.courseService
      .Put(data)
      .pipe(
        tap(() => {
          this.openNotification();
          this.router.navigate(['../../list'], { relativeTo: this.route });
        })
      )
      .subscribe();
  }
}
