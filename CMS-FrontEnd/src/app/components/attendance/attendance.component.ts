import { tap } from 'rxjs';
import { AttendanceService } from './shared/attendance.service';
import { BaseComponent } from './../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';
import { AttendanceList } from './shared/Attendance';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';
import { PaginationChangParams } from 'src/app/shared/interfaces/Table';

@Component({
  selector: 'app-attendance',
  templateUrl: './attendance.component.html',
  styleUrls: ['./attendance.component.less'],
})
export class AttendanceComponent extends BaseComponent implements OnInit {
  isLoading = true;
  records: PaginationResponse = { count: 0, records: [] };
  columns: string[] = [];
  constructor(
    injector: Injector,
    private attendanceService: AttendanceService
  ) {
    super(injector);
    this.columns = ['name', 'type', 'date'];
  }

  ngOnInit() {
    this.getAttendances().subscribe();
  }
  search(event: string) {
    if(true){
      this.pagination.SearchStatement = event;
      this.getAttendances().subscribe();
    }
  }
  getAttendances() {
    this.isLoading = true;
    return this.attendanceService.GetWithPagination(this.pagination).pipe(
      tap((response: any) => {
        this.records = response;
        this.isLoading = false;
      })
    );
  }
  onPaginationChanged(event: PaginationChangParams) {
    this.pagination.PageSize = event.pageSize;
    this.pagination.PageIndex = event.pageIndex;
    this.getAttendances().subscribe();
  }
  deleteAttendence(event: any) {
    this.attendanceService.Delete(event).subscribe(() => {
      this.openNotification();
      this.getAttendances().subscribe();
    });
  }
}
