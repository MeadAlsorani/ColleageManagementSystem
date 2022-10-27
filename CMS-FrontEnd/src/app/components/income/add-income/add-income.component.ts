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
  showAdditional = false;
  courseId: number = 0;
  studentId = 0;
  amounts = {
    paid: 0,
    agreed: 0,
    remaining: 0,
  };
  fields: FormField[] = [
    {
      code: 'studentId',
      label: 'Student',
      required: true,
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
  valueChanged(event: any) {
    const course = this.fields.find((x) => x.code == 'courseId');
    if (
      (event.studentId != null && course == null) ||
      (event.studentId != null && event.studentId != this.studentId)
    ) {
      this.incomeService
        .getStudentWithCourses(event.studentId)
        .subscribe((response: any) => {
          this.studentId = event.studentId;

          const field: FormField = {
            code: 'courseId',
            label: 'course',
            required: false,
            type: FormFieldType.dropdown,
          };

          field!.options = (response.coureses as any[]).map((r) => {
            return { code: r.id, label: `${r.className}-${r.name}` };
          });
          if (field.options.length == 0)
            this.openNotification('No courses', 'warning');
          this.fields = this.fields.filter(
            (x) =>
              x.code !== 'courseId' && x.code !== 'date' && x.code !== 'amount'
          );
          this.showAdditional = false;
          this.fields = [...this.fields, field];
        });
    }
    if (
      (event.courseId != null &&
        event.studentId != null &&
        this.showAdditional === false) ||
      (event.courseId != null &&
        this.courseId != null &&
        this.courseId != event.courseId)
    ) {
      this.incomeService
        .getIncomeAmounts(event.studentId, event.courseId)
        .subscribe((response: any) => {
          const field: FormField = {
            code: 'date',
            label: 'date',
            required: false,
            type: FormFieldType.date,
          };
          const amountField: FormField = {
            code: 'amount',
            label: 'amount',
            required: false,
            type: FormFieldType.number,
          };
          this.fields = this.fields.filter(
            (x) => x.code !== 'date' && x.code !== 'amount'
          );
          this.courseId = event.courseId;
          this.fields = [...this.fields, field, amountField];
          this.amounts = {
            paid: response.paidToDate,
            agreed: response.agreedAmount,
            remaining: response.remainingAmount,
          };
          this.showAdditional = true;
        });
    }
  }
}
