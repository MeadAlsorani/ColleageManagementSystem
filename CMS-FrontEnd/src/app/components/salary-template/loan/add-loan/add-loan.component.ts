import { BaseComponent } from './../../../../shared/components/Base.component';
import { SalaryTemplateService } from './../../shared/salary-template.service';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';
import { Component, OnInit, Injector } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-add-loan',
  templateUrl: './add-loan.component.html',
  styleUrls: ['./add-loan.component.less'],
})
export class AddLoanComponent extends BaseComponent implements OnInit {
  fields: FormField[] = [
    {
      code: 'amount',
      label: 'amount',
      required: true,
      type: FormFieldType.number,
    },
    {
      code: 'date',
      label: 'date',
      required: true,
      type: FormFieldType.date,
    },
  ];
  constructor(
    private salaryService: SalaryTemplateService,
    Injector: Injector
  ) {
    super(Injector);
  }

  ngOnInit() {}
  submit(data: any) {
    data.SalaryTemplateId = +this.route.snapshot.params['id'];
    this.salaryService.postLoan(data).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../loans'], { relativeTo: this.route });
    });
  }
}
