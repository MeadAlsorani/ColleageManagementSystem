import { Observable } from 'rxjs';
import { environment } from './../../../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { CommonService } from './../../../shared/services/common.service';
import { Injectable } from '@angular/core';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';

@Injectable()
export class StudentService extends CommonService {
  override get entity(): string {
    return 'Student';
  }
  constructor(http: HttpClient) {
    super(http);
  }

  getCourses(): Observable<PaginationResponse> {
    return this.http.get<PaginationResponse>(`${environment.apiUrl}Course`);
  }
  approveStudent(id: number) {
    return this.http.get(`${environment.apiUrl}Student/ApproveStudent/${id}`);
  }
}
