import { tap } from 'rxjs';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, Injector, OnInit } from '@angular/core';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';
import { StudentService } from '../shared/student.service';
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-edit-student',
  templateUrl: './edit-student.component.html',
  styleUrls: ['./edit-student.component.less'],
})
export class EditStudentComponent extends BaseComponent implements OnInit {
  fields: FormField[];
  formGroup: FormGroup;
  selectedId: number = 0;
  constructor(injector: Injector, private studetnService: StudentService) {
    super(injector);
    this.fields = [
      {
        code: 'firstName',
        label: 'First Name',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'lastName',
        label: 'Last Name',
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
        })
      )
      .subscribe();
  }
  submit(event: any) {}
}
