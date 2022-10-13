import { HttpClient } from '@angular/common/http';
import { CommonService } from './../../../shared/services/common.service';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class SessionYearService extends CommonService {
  override get entity(): string {
    return 'SessionYear';
  }
  constructor(http: HttpClient) {
    super(http);
  }
}
