import { tap } from 'rxjs';
import { AnnouncementsService } from './../shared/announcements.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import {
  FormField,
  FormFieldType,
} from './../../../shared/interfaces/FormField';
import { Component, OnInit, Injector } from '@angular/core';

@Component({
  selector: 'app-add-announcement',
  templateUrl: './add-announcement.component.html',
  styleUrls: ['./add-announcement.component.less'],
})
export class AddAnnouncementComponent extends BaseComponent implements OnInit {
  formFields: FormField[];
  constructor(
    private announcementService: AnnouncementsService,
    injector: Injector
  ) {
    super(injector);
    this.formFields = [
      {
        code: 'Title',
        label: 'Title',
        required: true,
        type: FormFieldType.string,
      },
      {
        code: 'Date',
        label: 'Date',
        required: true,
        type: FormFieldType.date,
      },
      {
        code: 'Type',
        label: 'Type',
        required: true,
        type: FormFieldType.dropdown,
        options: [
          { code: 1, label: 'Notice' },
          { code: 2, label: 'Event' },
          { code: 3, label: 'Holiday' },
        ],
      },
      {
        code: 'Message',
        label: 'Description',
        required: false,
        type: FormFieldType.text,
      },
    ];
  }

  ngOnInit() {}
  addAnnouncement(data: any) {
    console.log(data);
    this.announcementService
      .Post(data)
      .pipe(
        tap((response) => {
          this.openNotification();
          this.router.navigate(['../list'], { relativeTo: this.route });
        })
      )
      .subscribe();
  }
}
