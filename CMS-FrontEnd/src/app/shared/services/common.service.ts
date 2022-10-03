import { PaginationPayload } from './../interfaces/Request';
import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root',
})
export class CommonService {
  baseUrl = '';
  constructor(
    private http: HttpClient,
    @Inject('entity') private entity: string
  ) {
    this.baseUrl = environment.apiUrl + entity + '/';
  }

  Get(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}`);
  }
  GetWithPagination(payload: PaginationPayload) {
    return this.http.post(`${this.baseUrl}GetWithPagination`, payload);
  }
  GetDetails(id: number) {
    return this.http.get(`${this.baseUrl}/${id}`);
  }

  Post(data: any) {
    return this.http.post(`${this.baseUrl}`, data);
  }

  Put(data: any) {
    return this.http.put(`${this.baseUrl}`, data);
  }

  Delete(id: number) {
    return this.http.delete(`${this.baseUrl}/${id}`);
  }
}
