import { tap } from 'rxjs';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, Injector, OnInit } from '@angular/core';
import { FormField, FormFieldType } from 'src/app/shared/interfaces/FormField';
import { AnnouncementsService } from '../shared/announcements.service';

@Component({
  selector: 'app-edit-announcement',
  templateUrl: './edit-announcement.component.html',
  styleUrls: ['./edit-announcement.component.less'],
})
export class EditAnnouncementComponent extends BaseComponent implements OnInit {
  formFields: FormField[];
  formGroup: FormGroup;
  id: number = 0;
  constructor(
    private announcementService: AnnouncementsService,
    injector: Injector
  ) {
    super(injector);
    this.formFields = [
      {
        code: 'title',
        label: 'Title',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'date',
        label: 'Date',
        required: true,
        type: FormFieldType.date,
      },
      {
        code: 'type',
        label: 'Type',
        required: true,
        type: FormFieldType.dropdown,
        options: [
          { code: 1, label: this.translateService.instant('Notice') },
          { code: 2, label: this.translateService.instant('Event') },
          { code: 3, label: this.translateService.instant('Holiday') },
        ],
      },
      {
        code: 'message',
        label: 'Description',
        required: false,
        type: FormFieldType.text,
      },
    ];
    this.formGroup = this.formBuilder.group({});
    this.formFields.forEach((field) => {
      this.formGroup.addControl(
        field.code,
        new FormControl(null, field.required ? Validators.required : null)
      );
    });
  }

  ngOnInit() {
    this.route.params
      .pipe(
        tap((params) => {
          if (params['id'] != null) {
            this.id = +params['id'];
            this.getData();
          }
        })
      )
      .subscribe();
  }

  getData() {
    this.announcementService
      .GetDetails(this.id)
      .pipe(
        tap((response) => {
          this.formGroup.patchValue(response);
        })
      )
      .subscribe();
  }
  submit(event: any) {
    console.log(event);
    event.id = this.id;
    this.announcementService.Put(event).subscribe(() => {
      this.snackBar.open(
        this.translateService.instant('Operation succeeded'),
        undefined,
        {
          horizontalPosition: 'center',
          verticalPosition: 'top',
          duration: 4000,
          panelClass: 'success-panel',
        }
      );
      this.router.navigate(['../../list'], { relativeTo: this.route });
    });
  }
}
