import { tap, switchMap } from 'rxjs';
import { BaseComponent } from './../../shared/components/Base.component';
import { SessionYearService } from './shared/session-year.service';
import { PaginationResponse } from './../../shared/interfaces/Request';
import { Component, OnInit, Injector } from '@angular/core';
import { Action, PaginationChangParams } from 'src/app/shared/interfaces/Table';

@Component({
  selector: 'app-session-year',
  templateUrl: './session-year.component.html',
  styleUrls: ['./session-year.component.less'],
})
export class SessionYearComponent extends BaseComponent implements OnInit {
  buttons: Action[] = [];
  columns: string[];
  isLoading = true;
  records: PaginationResponse = { count: 0, records: [] };
  constructor(
    injector: Injector,
    private SessionYearService: SessionYearService
  ) {
    super(injector);
    this.columns = ['title', 'start', 'end'];
  }

  ngOnInit() {
    this.getSessions().subscribe();
  }
  search(event: string) {
    if(true){
      this.pagination.SearchStatement = event;
      this.getSessions().subscribe();
    }
  }
  deleteRecord(id: number) {
    this.SessionYearService.Delete(id)
      .pipe(
        tap(() => this.openNotification()),
        switchMap(() => this.getSessions())
      )
      .subscribe();
  }
  paginationChanged(data: PaginationChangParams) {
    this.pagination.PageIndex = data.pageIndex;
    this.pagination.PageSize = data.pageSize;
    this.getSessions().subscribe();
  }
  getSessions() {
    this.isLoading = true;
    return this.SessionYearService.GetWithPagination(this.pagination).pipe(
      tap((response) => {
        this.records = response;
        this.isLoading = false;
      })
    );
  }
}
