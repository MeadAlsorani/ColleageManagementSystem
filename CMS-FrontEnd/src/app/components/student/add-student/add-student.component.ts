import { StudentService } from './../shared/student.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';

@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.less'],
})
export class AddStudentComponent extends BaseComponent implements OnInit {
  fields: FormField[];
  constructor(injector: Injector, private studetnService: StudentService) {
    super(injector);
    this.fields = [
      {
        code: 'FirstName',
        label: 'First Name',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'LastName',
        label: 'Last Name',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'GuardianName',
        label: 'Guardian Name',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'PhoneNumber',
        label: 'Phone Number',
        required: false,
        type: FormFieldType.string,
      },
      {
        code: 'Address',
        label: 'Address',
        required: false,
        type: FormFieldType.text,
      },
      {
        code: 'ClassLevel',
        label: 'Class Level',
        required: true,
        type: FormFieldType.number,
      },
      {
        code: 'SchoolName',
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
  }

  ngOnInit() {}

  submitForm(event: any) {
    this.studetnService.Post(event).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../list'], { relativeTo: this.route });
    });
  }
}
