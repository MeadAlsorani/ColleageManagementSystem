import { CommonService } from './../../../shared/services/common.service';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export class StaffService extends CommonService {
  override get entity(): string {
    return 'Staff';
  }
  constructor(http: HttpClient) {
    super(http);
  }
}
