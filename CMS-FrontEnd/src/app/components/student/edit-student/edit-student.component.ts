import { PaginationResponse } from './../../../shared/interfaces/Request';
import { tap, switchMap } from 'rxjs';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, Injector, OnInit } from '@angular/core';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';
import { StudentService } from '../shared/student.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { MatTableDataSource } from '@angular/material/table';
import { SelectionModel } from '@angular/cdk/collections';

@Component({
  selector: 'app-edit-student',
  templateUrl: './edit-student.component.html',
  styleUrls: ['./edit-student.component.less'],
})
export class EditStudentComponent extends BaseComponent implements OnInit {
  fields: FormField[];
  formGroup: FormGroup;
  selectedId: number = 0;
  student: any = {};
  courseColumns: string[] = ['select', 'className', 'name', 'teacher', 'price'];
  dataSource = new MatTableDataSource<any>();
  selection = new SelectionModel<any>(true, []);

  constructor(injector: Injector, private studetnService: StudentService) {
    super(injector);
    this.fields = [
      {
        code: 'name',
        label: 'Name',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'nationalId',
        label: 'NationalId',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'guardianName',
        label: 'Guardian Name',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'phoneNumber',
        label: 'Phone Number',
        required: false,
        type: FormFieldType.string,
      },
      {
        code: 'coursesContent',
        label: 'Courses',
        required: false,
        type: FormFieldType.text,
      },
      {
        code: 'address',
        label: 'Address',
        required: false,
        type: FormFieldType.text,
      },
      {
        code: 'classLevel',
        label: 'Class Level',
        required: true,
        type: FormFieldType.number,
      },
      {
        code: 'schoolName',
        label: 'School Name',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'registerationDate',
        label: 'Registeration Date',
        required: true,
        type: FormFieldType.date,
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
    this.route.params.subscribe((params) => {
      if (params['id'] != null) {
        this.selectedId = +params['id'];
        this.getStudentData();
      }
    });
  }
  getStudentData() {
    this.studetnService
      .GetDetails(this.selectedId)
      .pipe(
        tap((response) => {
          this.formGroup.patchValue(response);
          this.student = response;
        }),
        switchMap((student) => this.studetnService.getCourses()),
        tap((courses: PaginationResponse) => {
          this.dataSource.data = courses.records;
          const selectedCourses = this.student.studentCoursesIds as any[];
          selectedCourses.forEach((course) => {
            const c = courses.records.find((x) => x.id == course);
            this.selection.select(c);
          });
          this.selection.select();
        })
      )
      .subscribe();
  }
  submit(event: any) {
    event.id = this.selectedId;
    const selectedCourses = this.selection.selected.map((x) => x.id);
    event.studentCoursesIds = selectedCourses;
    this.studetnService.Put(event).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../../list'], { relativeTo: this.route });
    });
  }

  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.dataSource.data.length;
    return numSelected === numRows;
  }

  /** Selects all rows if they are not all selected; otherwise clear selection. */
  masterToggle() {
    if (this.isAllSelected()) {
      this.selection.clear();
      return;
    }

    this.selection.select(...this.dataSource.data);
  }
}
