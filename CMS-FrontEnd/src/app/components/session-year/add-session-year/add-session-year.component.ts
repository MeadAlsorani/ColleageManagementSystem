import { tap } from 'rxjs';
import { SessionYearService } from './../shared/session-year.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';

@Component({
  selector: 'app-add-session-year',
  templateUrl: './add-session-year.component.html',
  styleUrls: ['./add-session-year.component.less'],
})
export class AddSessionYearComponent extends BaseComponent implements OnInit {
  fields: FormField[];
  constructor(
    injector: Injector,
    private sessionYearService: SessionYearService
  ) {
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
  }

  ngOnInit() {}

  submit(data: any) {
    this.sessionYearService
      .Post(data)
      .pipe(
        tap(() => {
          this.openNotification();
          this.router.navigate(['../'], { relativeTo: this.route });
        })
      )
      .subscribe();
  }
}
