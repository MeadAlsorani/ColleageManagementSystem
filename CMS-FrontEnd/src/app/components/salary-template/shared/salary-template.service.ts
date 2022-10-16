import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { CommonService } from './../../../shared/services/common.service';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';

@Injectable()
export class SalaryTemplateService extends CommonService {
  override get entity(): string {
    return 'SalaryTemplate';
  }
  constructor(http: HttpClient) {
    super(http);
  }
  getStaffs() {
    return this.http.get(`${environment.apiUrl}Staff`);
  }

  getLoans(id: number): Observable<PaginationResponse> {
    return this.http.get<PaginationResponse>(
      `${environment.apiUrl}Loan?salaryTemplateId=${id}`
    );
  }
  postLoan(data: any) {
    return this.http.post(`${environment.apiUrl}Loan`, data);
  }
  deleteLoan(id: number) {
    return this.http.delete(`${environment.apiUrl}Loan?id=${id}`);
  }
}
