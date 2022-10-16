import { FormGroup, FormControl, Validators } from '@angular/forms';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';
import { SalaryTemplateService } from './../shared/salary-template.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';

@Component({
  selector: 'app-edit-salary-template',
  templateUrl: './edit-salary-template.component.html',
  styleUrls: ['./edit-salary-template.component.less'],
})
export class EditSalaryTemplateComponent
  extends BaseComponent
  implements OnInit
{
  fields: FormField[] = [];
  formGroup: FormGroup;
  selectedId: number = 0;
  constructor(
    injector: Injector,
    private salaryService: SalaryTemplateService
  ) {
    super(injector);
    this.fields = [
      {
        code: 'staffId',
        label: 'staff',
        required: true,
        type: FormFieldType.dropdown,
        options: [],
      },
      {
        code: 'salaryPerHour',
        label: 'salaryPerHour',
        required: true,
        type: FormFieldType.number,
      },
      {
        code: 'totalDuration',
        label: 'totalDuration',
        required: true,
        type: FormFieldType.number,
      },
      {
        code: 'basicSalary',
        label: 'basicSalary',
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
    this.salaryService.getStaffs().subscribe((response: any) => {
      const field = this.fields.find((x) => x.code === 'staffId');
      field!.options = (response.records as any[]).map((x) => {
        return { code: x.id, label: x.fullName };
      });
    });
    const params$ = this.route.params.subscribe((params) => {
      this.selectedId = +params['id'];
      this.getData();
    });
    this.subscriptions.push(params$);
  }
  getData() {
    this.salaryService.GetDetails(this.selectedId).subscribe((response) => {
      Object.keys(response).forEach((key) => {
        this.formGroup?.addControl(key, new FormControl());
      });
      this.formGroup?.patchValue(response);
    });
  }

  submit(data: any) {
    this.salaryService.Put(data).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../../list'], { relativeTo: this.route });
    });
  }
}
