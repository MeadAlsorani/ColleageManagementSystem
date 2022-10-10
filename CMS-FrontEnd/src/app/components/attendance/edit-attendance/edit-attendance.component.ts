import { Observable, tap } from 'rxjs';
import { AttendanceService } from './../shared/attendance.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';
import {
  DropdownOption,
  FormField,
  FormFieldType,
} from 'src/app/shared/interfaces/FormField';
import { FormGroup, Validators, FormControl } from '@angular/forms';

@Component({
  selector: 'app-edit-attendance',
  templateUrl: './edit-attendance.component.html',
  styleUrls: ['./edit-attendance.component.less'],
})
export class EditAttendanceComponent extends BaseComponent implements OnInit {
  fields: FormField[];
  formGroup: FormGroup;
  selectedId: number = 0;
  constructor(
    injector: Injector,
    private attendanceService: AttendanceService
  ) {
    super(injector);
    this.fields = [
      {
        code: 'type',
        label: 'Type',
        required: true,
        type: FormFieldType.dropdown,
        options: [
          { code: 1, label: 'Student' },
          { code: 2, label: 'Staff' },
        ],
      },
      {
        code: 'date',
        label: 'Date',
        required: true,
        type: FormFieldType.date,
      },
    ];
    this.formGroup = this.formBuilder.group({
      type: [null, Validators.required],
      date: [null, Validators.required],
    });
  }

  ngOnInit() {
    this.route.params.subscribe((params) => {
      if (params['id'] != null) this.selectedId = +params['id'];
      this.getAttendanceDetails();
    });
  }

  getAttendanceDetails() {
    this.attendanceService
      .GetDetails(this.selectedId)
      .pipe(
        tap((response: any) => {
          let observable: Observable<any>;
          if (response.Type == 1) {
            observable = this.attendanceService.getStudents();
          } else {
            observable = this.attendanceService.getStaffs();
          }
          observable.subscribe((resp: any) => {
            const records = resp.records as any[];
            const options: DropdownOption[] = [];
            records.forEach((student) => {
              options.push({
                code: student.id,
                label: student.fullName,
              });
            });
            this.fields = this.fields.filter((x) => x.code != 'staffStudentId');
            this.formGroup.addControl(
              'staffStudentId',
              new FormControl(null, Validators.required)
            );
            this.formGroup.patchValue(response);
            this.fields = [
              ...this.fields,
              {
                code: 'staffStudentId',
                label: response.Type == 1 ? 'Student' : 'Staff',
                required: true,
                type: FormFieldType.dropdown,
                options: options,
              },
            ];
          });
        })
      )
      .subscribe();
  }
  submit(event: any) {
    event.id = this.selectedId;
    this.attendanceService.Put(event).subscribe(() => {
      this.snackBar.open(
        this.translateService.instant('Operation succeeded'),
        undefined,
        {
          horizontalPosition: 'center',
          verticalPosition: 'top',
          duration: 4000,
          panelClass: 'success-panel',
        }
      );
      this.router.navigate(['../../list'], { relativeTo: this.route });
    });
  }
}
