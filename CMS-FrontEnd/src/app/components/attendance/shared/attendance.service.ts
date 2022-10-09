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
}
