import { StaffService } from './../shared/staff.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Component, OnInit, Injector } from '@angular/core';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';

@Component({
  selector: 'app-edit-staff',
  templateUrl: './edit-staff.component.html',
  styleUrls: ['./edit-staff.component.less'],
})
export class EditStaffComponent extends BaseComponent implements OnInit {
  fields: FormField[] = [];
  formGroup: FormGroup;
  selectedId: number = 0;
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
        code: 'salary',
        label: 'Salary',
        required: true,
        type: FormFieldType.number,
      },
    ];
    this.formGroup = this.formBuilder.group({});
    this.fields.forEach((field) => {
      this.formGroup.addControl(
        field.code,
        new FormControl(null, Validators.required)
      );
    });
  }

  ngOnInit() {
    const params$ = this.route.params.subscribe((params) => {
      this.selectedId = +params['id'];
      this.getStaffDetails();
    });
  }
  getStaffDetails() {
    this.staffService.GetDetails(this.selectedId).subscribe((response: any) => {
      this.formGroup.addControl('role', new FormControl(response.role));
      this.formGroup.patchValue(response);
    });
  }

  submit(data: any) {
    data.id = this.selectedId;
    this.staffService.Put(data).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../../list'], { relativeTo: this.route });
    });
  }
}
