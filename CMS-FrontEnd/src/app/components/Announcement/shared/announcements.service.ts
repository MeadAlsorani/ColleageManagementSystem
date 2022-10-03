import { HttpClient } from '@angular/common/http';
import { CommonService } from './../../../shared/services/common.service';
import { Injectable } from '@angular/core';

@Injectable()
export class AnnouncementsService extends CommonService {
  constructor(http: HttpClient) {
    super(http, 'Announcements');
  }
}
