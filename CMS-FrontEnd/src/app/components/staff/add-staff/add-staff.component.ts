import { tap } from 'rxjs';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, Injector, OnInit } from '@angular/core';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';
import { StaffService } from '../shared/staff.service';

@Component({
  selector: 'app-add-staff',
  templateUrl: './add-staff.component.html',
  styleUrls: ['./add-staff.component.less'],
})
export class AddStaffComponent extends BaseComponent implements OnInit {
  fields: FormField[] = [];
  constructor(injector: Injector, private staffService: StaffService) {
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
        code: 'email',
        label: 'email',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'phoneNumber',
        label: 'Phone Number',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'address',
        label: 'Address',
        required: true,
        type: FormFieldType.text,
      },
      {
        code: 'role',
        label: 'role',
        required: true,
        type: FormFieldType.dropdown,
        options: [
          {
            code: 1,
            label: 'Teacher',
          },
          {
            code: 2,
            label: 'Admin',
          },
          {
            code: 3,
            label: 'Employee',
          },
        ],
      },
      {
        code: 'salary',
        label: 'Salary',
        required: true,
        type: FormFieldType.number,
      },
    ];
  }

  ngOnInit() {}
  submit(data: any) {
    this.staffService.Post(data).pipe(
      tap(() => {
        this.openNotification();
        this.router.navigate(['../list'], { relativeTo: this.route });
      })
    ).subscribe();
  }
}
