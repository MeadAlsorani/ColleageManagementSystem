import { HttpClient } from '@angular/common/http';
import { CommonService } from './../../../shared/services/common.service';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';

@Injectable()
export class IncomeService extends CommonService {
  override get entity(): string {
    return 'IncomeTransaction';
  }
  constructor(http: HttpClient) {
    super(http);
  }

  getIncomeAmounts(studentId: number, courseId: number) {
    return this.http.get(
      `${environment.apiUrl}IncomeTransaction/amounts?studentId=${studentId}&courseId=${courseId}`
    );
  }
  getStudents(): Observable<PaginationResponse> {
    return this.http.get<PaginationResponse>(`${environment.apiUrl}Student`);
  }
  getStudentWithCourses(id: number) {
    return this.http.get(`${environment.apiUrl}Student/WithCourses/${id}`);
  }
  getCourses(): Observable<PaginationResponse> {
    return this.http.get<PaginationResponse>(`${environment.apiUrl}Course`);
  }
}
