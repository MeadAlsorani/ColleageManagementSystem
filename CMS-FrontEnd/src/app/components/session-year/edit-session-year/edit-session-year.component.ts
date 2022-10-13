import { tap, switchMap } from 'rxjs';
import { BaseComponent } from './../../../shared/components/Base.component';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import {
  FormField,
  FormFieldType,
} from './../../../shared/interfaces/FormField';
import { Component, OnInit, Injector } from '@angular/core';
import { SessionYearService } from '../shared/session-year.service';

@Component({
  selector: 'app-edit-session-year',
  templateUrl: './edit-session-year.component.html',
  styleUrls: ['./edit-session-year.component.less'],
})
export class EditSessionYearComponent extends BaseComponent implements OnInit {
  fields: FormField[];
  formGroup: FormGroup;
  selectedId: number = 0;
  constructor(injector: Injector, private sessionService: SessionYearService) {
    super(injector);
    this.fields = [
      {
        code: 'title',
        label: 'Title',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'start',
        label: 'start',
        required: true,
        type: FormFieldType.date,
      },
      {
        code: 'end',
        label: 'end',
        required: true,
        type: FormFieldType.date,
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
    this.route.params
      .pipe(
        tap((params) => {
          this.selectedId = +params['id'];
        }),
        switchMap(() => this.getSessionYear())
      )
      .subscribe();
  }

  getSessionYear() {
    return this.sessionService.GetDetails(this.selectedId).pipe(
      tap((response) => {
        this.formGroup.addControl('id', new FormControl(this.selectedId));
        this.formGroup.patchValue(response);
      })
    );
  }
  submit(data: any) {
    this.sessionService.Put(data).subscribe(() => {
      this.openNotification();
      this.router.navigate(['../../list'], { relativeTo: this.route });
    });
  }
}
