import { DropdownOption } from './../../../shared/interfaces/FormField';
import { AttendanceService } from './../shared/attendance.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { FormGroup } from '@angular/forms';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';
import { Component, OnInit, Injector } from '@angular/core';

@Component({
  selector: 'app-add-attendance',
  templateUrl: './add-attendance.component.html',
  styleUrls: ['./add-attendance.component.less'],
})
export class AddAttendanceComponent extends BaseComponent implements OnInit {
  fields: FormField[];
  constructor(
    injector: Injector,
    private attencanceService: AttendanceService
  ) {
    super(injector);
    this.fields = [
      {
        code: 'Type',
        label: 'Type',
        required: true,
        type: FormFieldType.dropdown,
        options: [
          { code: 1, label: 'Student' },
          { code: 2, label: 'Staff' },
        ],
      },
      {
        code: 'Date',
        label: 'Date',
        required: true,
        type: FormFieldType.date,
      },
    ];
  }

  ngOnInit() {}
  valueChanged(event: any) {
    console.log(event);
    if (event.Type != null) {
      if (event.Type == 1) {
        this.attencanceService.getStudents().subscribe((resp: any) => {
          const students = resp as any[];
          const options: DropdownOption[] = [];
          students.forEach((student) => {
            options.push({
              code: student.id,
              label: student.fullName,
            });
          });
          this.fields = this.fields.filter((x) => x.code != 'StaffStudentId');
          this.fields = [
            ...this.fields,
            {
              code: 'StaffStudentId',
              label: 'Student',
              required: true,
              type: FormFieldType.dropdown,
              options: options,
            },
          ];
        });
      } else {
      }
    }
  }
  submit(event: any) {
    this.attencanceService.Post(event).subscribe(() => {
      this.openSnackBar();
      this.router.navigate(['../list'], { relativeTo: this.route });
    });
  }
  openSnackBar() {
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
  }
}
