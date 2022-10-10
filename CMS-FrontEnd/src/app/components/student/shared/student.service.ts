import { HttpClient } from '@angular/common/http';
import { CommonService } from './../../../shared/services/common.service';
import { Injectable } from '@angular/core';

@Injectable()
export class StudentService extends CommonService {
  override get entity(): string {
    return 'Student';
  }
  constructor(http: HttpClient) {
    super(http);
  }
}
