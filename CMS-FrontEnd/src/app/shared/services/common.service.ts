import { PaginationPayload } from './../interfaces/Request';
import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { map, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Menu } from '../interfaces/Menu';
import { User } from '../interfaces/User';

@Injectable({
  providedIn: 'root',
})
export class CommonService {
  baseUrl = '';
  get entity() {
    return '';
  }
  constructor(private http: HttpClient) {
    this.baseUrl = environment.apiUrl + this.entity;
  }

  Get(): Observable<any[]> {
    return this.http.get<any[]>(`${this.baseUrl}`);
  }
  GetWithPagination(payload: PaginationPayload) {
    return this.http.post(`${this.baseUrl}/GetWithPagination`, payload);
  }
  GetDetails(id: number) {
    return this.http.get(`${this.baseUrl}/${id}`);
  }

  Post(data: any) {
    return this.http.post(`${this.baseUrl}`, data);
  }

  Put(data: any) {
    return this.http.put(`${this.baseUrl}/${data.id}`, data);
  }

  Delete(id: number) {
    return this.http.delete(`${this.baseUrl}/${id}`);
  }
  getMenus(): Observable<Menu[]> {
    return this.http
      .get<{ [key: string]: Menu[] }>(`${environment.apiUrl}Common`)
      .pipe(
        map((response) => {
          const user = JSON.parse(localStorage.getItem('userData')!) as User;
          return response[user.role];
        })
      );
  }
}
