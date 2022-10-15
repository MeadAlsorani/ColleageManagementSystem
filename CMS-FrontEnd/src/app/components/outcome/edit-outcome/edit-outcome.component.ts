import { tap } from 'rxjs';
import { OutcomeService } from './../shared/outcome.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import {
  FormField,
  FormFieldType,
} from './../../../shared/interfaces/FormField';
import { Component, OnInit, Injector } from '@angular/core';

@Component({
  selector: 'app-edit-outcome',
  templateUrl: './edit-outcome.component.html',
  styleUrls: ['./edit-outcome.component.less'],
})
export class EditOutcomeComponent extends BaseComponent implements OnInit {
  fields: FormField[] = [];
  formGroup: FormGroup;
  selectedId: number = 0;
  constructor(injector: Injector, private outcomeService: OutcomeService) {
    super(injector);
    this.fields = [
      {
        code: 'description',
        label: 'description',
        required: false,
        type: FormFieldType.text,
      },
      {
        code: 'amount',
        label: 'amount',
        required: true,
        type: FormFieldType.number,
      },
    ];
    this.formGroup = this.formBuilder.group({
      amount: [null, Validators.required],
      description: [''],
      date: [null],
      type: [],
    });
  }

  ngOnInit() {
    this.route.params.subscribe((params) => {
      this.selectedId = +params['id'];
      this.getData();
    });
  }
  getData() {
    this.outcomeService
      .GetDetails(this.selectedId)
      .pipe(
        tap((response: any) => {
          if (response.staffId != null && response.staffId != 0)
            this.formGroup.addControl('staffId', new FormControl());
          this.formGroup.patchValue(response);
        })
      )
      .subscribe();
  }
  submit(data: any) {
    data.id = this.selectedId;
    this.outcomeService.Put(data).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../../list'], { relativeTo: this.route });
    });
  }
}
