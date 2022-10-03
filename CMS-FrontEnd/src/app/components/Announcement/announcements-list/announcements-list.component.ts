import { AnnouncementsService } from './../shared/announcements.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';
import { AnnouncementList } from '../shared/Announcement';
import { tap } from 'rxjs';

@Component({
  selector: 'app-announcements-list',
  templateUrl: './announcements-list.component.html',
  styleUrls: ['./announcements-list.component.less'],
})
export class AnnouncementsListComponent
  extends BaseComponent
  implements OnInit
{
  records: AnnouncementList[] = [];
  constructor(injector: Injector, private service: AnnouncementsService) {
    super(injector);
  }

  ngOnInit() {
    this.getAnnouncements().subscribe();
  }

  getAnnouncements() {
    return this.service.GetWithPagination(this.pagination).pipe(
      tap((response) => {
        console.log(response);
      })
    );
  }
}
