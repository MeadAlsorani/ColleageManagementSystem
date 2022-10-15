import { IncomeService } from './../shared/income.service';
import { FormGroup, Validators } from '@angular/forms';
import { BaseComponent } from './../../../shared/components/Base.component';
import {
  FormField,
  FormFieldType,
} from './../../../shared/interfaces/FormField';
import { Component, OnInit, Injector } from '@angular/core';

@Component({
  selector: 'app-edit-income',
  templateUrl: './edit-income.component.html',
  styleUrls: ['./edit-income.component.less'],
})
export class EditIncomeComponent extends BaseComponent implements OnInit {
  fields: FormField[] = [];
  formGroup: FormGroup;
  selectedId = 0;
  constructor(injector: Injector, private incomeService: IncomeService) {
    super(injector);
    this.fields = [
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
        code: 'courseId',
        label: 'course',
        required: false,
        type: FormFieldType.dropdown,
      },
    ];
    this.formGroup = this.formBuilder.group({
      amount: [null, Validators.required],
      date: [null, Validators.required],
      courseId: [null, Validators.required],
      studentId: [null, Validators.required],
    });
  }

  ngOnInit() {
    this.getCourse();
    this.route.params.subscribe((params) => {
      this.selectedId = +params['id'];
      this.getData();
    });
  }
  getData() {
    this.incomeService
      .GetDetails(this.selectedId)
      .subscribe((response: any) => {
        this.formGroup.patchValue(response);
      });
  }
  getCourse() {
    this.incomeService.getCourses().subscribe((resp) => {
      const field = this.fields.find((x) => x.code == 'courseId');
      field!.options = resp.records.map((r) => {
        return { code: r.id, label: `${r.className}-${r.name}` };
      });
    });
  }
  submit(data: any) {
    data.id = this.selectedId;
    this.incomeService.Put(data).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../../list'], { relativeTo: this.route });
    });
  }
}
