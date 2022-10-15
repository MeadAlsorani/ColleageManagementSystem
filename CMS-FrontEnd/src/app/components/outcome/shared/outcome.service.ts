import { HttpClient } from '@angular/common/http';
import { CommonService } from './../../../shared/services/common.service';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable()
export class OutcomeService extends CommonService {
  override get entity(): string {
    return 'OutcomeTransactions';
  }
  constructor(http: HttpClient) {
    super(http);
  }
  getStaffs() {
    return this.http.get(`${environment.apiUrl}Staff`);
  }
}
