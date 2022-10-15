import { tap } from 'rxjs';
import { BaseComponent } from './../../../../shared/components/Base.component';
import { Component, Injector, Input, OnInit } from '@angular/core';
import { AttendanceService } from 'src/app/components/attendance/shared/attendance.service';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';

@Component({
  selector: 'app-attendance-dialog',
  templateUrl: './attendance-dialog.component.html',
  styleUrls: ['./attendance-dialog.component.less'],
  providers: [AttendanceService],
})
export class AttendanceDialogComponent extends BaseComponent implements OnInit {
  isLoading = true;
  date = new Date();
  startDate: Date = new Date(this.date.getFullYear(), this.date.getMonth(), 1);
  endDate: Date = new Date(
    this.date.getFullYear(),
    this.date.getMonth() + 1,
    0
  );
  @Input() set data(value: { id: number; type: string }) {
    if (value != null) {
      if (value.type == 'student') {
        this.getStudentAttendances(value.id);
      } else {
        this.getStaffAttendances(value.id);
      }
    }
  }
  records: PaginationResponse = { count: 0, records: [] };
  columns: string[] = [];
  constructor(
    injector: Injector,
    private attendanceService: AttendanceService
  ) {
    super(injector);
    this.columns = ['date'];
  }

  ngOnInit() {}

  getStudentAttendances(id: number) {
    this.isLoading = true;
    this.attendanceService
      .getStudentAttendances(id, this.startDate, this.endDate)
      .pipe(
        tap((response: any[]) => {
          this.isLoading = false;
          this.records = { count: response.length, records: response };
        })
      )
      .subscribe();
  }
  getStaffAttendances(id: number) {
    this.isLoading = true;
    this.attendanceService
      .getStaffAttendances(id, this.startDate, this.endDate)
      .pipe(
        tap((response: any[]) => {
          this.isLoading = false;
          this.records = { count: response.length, records: response };
        })
      )
      .subscribe();
  }
}
