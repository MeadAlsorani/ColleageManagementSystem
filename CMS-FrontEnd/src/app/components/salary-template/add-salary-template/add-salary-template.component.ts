import { SalaryTemplateService } from './../shared/salary-template.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';
import { Component, OnInit, Injector } from '@angular/core';

@Component({
  selector: 'app-add-salary-template',
  templateUrl: './add-salary-template.component.html',
  styleUrls: ['./add-salary-template.component.less'],
})
export class AddSalaryTemplateComponent
  extends BaseComponent
  implements OnInit
{
  fields: FormField[] = [
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
  constructor(
    injector: Injector,
    private salaryService: SalaryTemplateService
  ) {
    super(injector);
  }

  ngOnInit() {
    this.salaryService.getStaffs().subscribe((response: any) => {
      const field = this.fields.find((x) => x.code === 'staffId');
      field!.options = (response.records as any[]).map((x) => {
        return { code: x.id, label: x.fullName };
      });
    });
  }

  submit(data: any) {
    this.salaryService.Post(data).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../list'], { relativeTo: this.route });
    });
  }
}
