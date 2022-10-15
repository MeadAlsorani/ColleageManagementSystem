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
  getStudents(): Observable<PaginationResponse> {
    return this.http.get<PaginationResponse>(`${environment.apiUrl}Student`);
  }
  getCourses(): Observable<PaginationResponse> {
    return this.http.get<PaginationResponse>(`${environment.apiUrl}Course`);
  }
}
