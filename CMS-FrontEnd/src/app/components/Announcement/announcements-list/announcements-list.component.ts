import { PaginationChangParams } from './../../../shared/interfaces/Table';
import { AnnouncementsService } from './../shared/announcements.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';
import { AnnouncementList } from '../shared/Announcement';
import { switchMap, tap } from 'rxjs';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';

@Component({
  selector: 'app-announcements-list',
  templateUrl: './announcements-list.component.html',
  styleUrls: ['./announcements-list.component.less'],
})
export class AnnouncementsListComponent
  extends BaseComponent
  implements OnInit
{
  isLoading = true;
  records: PaginationResponse = { count: 0, records: [] };
  columns: string[] = [];
  constructor(injector: Injector, private service: AnnouncementsService) {
    super(injector);
    this.columns = ['title', 'type', 'date'];
  }

  ngOnInit() {
    this.getAnnouncements().subscribe();
  }

  getAnnouncements() {
    this.isLoading = true;
    return this.service.GetWithPagination(this.pagination).pipe(
      tap((response: any) => {
        this.records = response;

        this.isLoading = false;
      })
    );
  }
  onPaginationChanged(event: PaginationChangParams) {
    this.pagination.PageSize = event.pageSize;
    this.pagination.PageIndex = event.pageIndex;
    this.getAnnouncements().subscribe();
  }
  deleteRecord(id: number) {
    this.service
      .Delete(id)
      .pipe(
        tap(() => {
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
        }),
        switchMap(() => this.getAnnouncements())
      )
      .subscribe();
  }
}
