import { tap } from 'rxjs';
import { AttendanceService } from './shared/attendance.service';
import { BaseComponent } from './../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';
import { AttendanceList } from './shared/Attendance';

@Component({
  selector: 'app-attendance',
  templateUrl: './attendance.component.html',
  styleUrls: ['./attendance.component.less'],
})
export class AttendanceComponent extends BaseComponent implements OnInit {
  isLoading = true;
  records: AttendanceList[] = [];
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

  getAttendances() {
    this.isLoading = true;
    return this.attendanceService.GetWithPagination(this.pagination).pipe(
      tap((response: any) => {
        this.records = response;
        this.isLoading = false;
      })
    );
  }
}
