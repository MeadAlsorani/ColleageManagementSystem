import { tap, switchMap } from 'rxjs';
import { BaseComponent } from './../../shared/components/Base.component';
import { PaginationResponse } from './../../shared/interfaces/Request';
import { Component, OnInit, Injector } from '@angular/core';
import { Action, PaginationChangParams } from 'src/app/shared/interfaces/Table';
import { StaffService } from './shared/staff.service';

@Component({
  selector: 'app-staff',
  templateUrl: './staff.component.html',
  styleUrls: ['./staff.component.less'],
})
export class StaffComponent extends BaseComponent implements OnInit {
  records: PaginationResponse = { count: 0, records: [] };
  buttons: Action[] = [];
  columns: string[] = [];
  isLoading = true;
  constructor(injector: Injector, private staffService: StaffService) {
    super(injector);
    this.columns = ['fullName', 'email', 'phoneNumber', 'address', 'role'];
  }

  ngOnInit() {
    this.getdata().subscribe();
  }

  deleteStaff(id: number) {
    return this.staffService
      .Delete(id)
      .pipe(
        tap(() => {
          this.openNotification();
        }),
        switchMap(() => this.getdata())
      )
      .subscribe();
  }

  getdata() {
    this.isLoading = true;
    return this.staffService.GetWithPagination(this.pagination).pipe(
      tap((response) => {
        this.records = response;
        this.isLoading = false;
      })
    );
  }
  executeAction(data: any) {}
  paginationChanged(data: PaginationChangParams) {
    this.pagination.PageIndex = data.pageIndex;
    this.pagination.PageSize = data.pageSize;
    this.getdata().subscribe();
  }
}
