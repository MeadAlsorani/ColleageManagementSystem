import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { CommonService } from './../../../shared/services/common.service';
import { Injectable } from '@angular/core';

@Injectable()
export class AttendanceService extends CommonService {
  override get entity() {
    return 'Attendance';
  }
  constructor(http: HttpClient) {
    super(http);
  }
  getStudents() {
    return this.http.get(`${environment.apiUrl}Student`);
  }
  getStaffs() {
    return this.http.get(`${environment.apiUrl}Staff`);
  }

  getStudentAttendances(
    id: number,
    startDate: Date,
    endDate: Date
  ): Observable<any[]> {
    const start = JSON.stringify(startDate);
    const end = JSON.stringify(endDate);
    return this.http.post<any[]>(
      `${environment.apiUrl}Attendance/Student/${id}`,
      {
        startDate: startDate,
        endDate: endDate,
      }
    );
  }
  getStaffAttendances(
    id: number,
    startDate: Date,
    endDate: Date
  ): Observable<any[]> {
    const start = JSON.stringify(startDate);
    const end = JSON.stringify(endDate);
    return this.http.post<any[]>(
      `${environment.apiUrl}Attendance/Staff/${id}`,
      {
        startDate: startDate,
        endDate: endDate,
      }
    );
  }
}
