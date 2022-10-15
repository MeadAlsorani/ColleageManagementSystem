import { tap } from 'rxjs';
import { OutcomeService } from './../shared/outcome.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import {
  FormField,
  FormFieldType,
} from './../../../shared/interfaces/FormField';
import { Component, OnInit, Injector } from '@angular/core';

@Component({
  selector: 'app-add-outcome',
  templateUrl: './add-outcome.component.html',
  styleUrls: ['./add-outcome.component.less'],
})
export class AddOutcomeComponent extends BaseComponent implements OnInit {
  fields: FormField[] = [];
  constructor(injector: Injector, private outcomeService: OutcomeService) {
    super(injector);
    this.fields = [
      {
        code: 'type',
        label: 'type',
        required: true,
        type: FormFieldType.dropdown,
        options: [
          { code: 1, label: 'Purchase' },
          { code: 2, label: 'Salary' },
          { code: 3, label: 'Other' },
        ],
      },
      {
        code: 'staffId',
        label: 'Staff',
        required: false,
        type: FormFieldType.dropdown,
      },
      {
        code: 'date',
        label: 'date',
        required: true,
        type: FormFieldType.date,
      },
      {
        code: 'amount',
        label: 'amount',
        required: true,
        type: FormFieldType.number,
      },
      {
        code: 'description',
        label: 'description',
        required: false,
        type: FormFieldType.text,
      },
    ];
  }

  ngOnInit() {
    this.outcomeService
      .getStaffs()
      .pipe(
        tap((response: any) => {
          const records = response.records as any[];
          const field = this.fields.find((x) => x.code === 'staffId');
          field!.options = records.map((x) => {
            return { code: x.id, label: x.fullName };
          });
        })
      )
      .subscribe();
  }
  submit(data: any) {
    this.outcomeService.Post(data).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../list'], { relativeTo: this.route });
    });
  }
}
