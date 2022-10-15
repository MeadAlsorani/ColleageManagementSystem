import { switchMap, tap } from 'rxjs';
import { IncomeService } from './../shared/income.service';
import {
  FormField,
  FormFieldType,
} from './../../../shared/interfaces/FormField';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, Injector, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-income',
  templateUrl: './add-income.component.html',
  styleUrls: ['./add-income.component.less'],
})
export class AddIncomeComponent extends BaseComponent implements OnInit {
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
    {
      code: 'studentId',
      label: 'Student',
      required: true,
      type: FormFieldType.dropdown,
    },
    {
      code: 'courseId',
      label: 'course',
      required: false,
      type: FormFieldType.dropdown,
    },
  ];
  constructor(injector: Injector, private incomeService: IncomeService) {
    super(injector);
  }

  ngOnInit() {
    this.getOptions();
  }
  getOptions() {
    this.incomeService
      .getStudents()
      .pipe(
        tap((response) => {
          console.log(response);
          const field = this.fields.find((x) => x.code == 'studentId');
          field!.options = response.records.map((r) => {
            return { code: r.id, label: r.fullName };
          });
        }),
        switchMap(() => this.incomeService.getCourses()),
        tap((resp) => {
          console.log(resp);
          const field = this.fields.find((x) => x.code == 'courseId');
          field!.options = resp.records.map((r) => {
            return { code: r.id, label: `${r.className}-${r.name}` };
          });
        })
      )
      .subscribe();
  }
  submit(event: any) {
    this.incomeService.Post(event).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../list'], { relativeTo: this.route });
    });
  }
}
