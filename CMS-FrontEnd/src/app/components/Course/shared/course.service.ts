import { PaginationResponse } from 'src/app/shared/interfaces/Request';
import { map, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { CommonService } from './../../../shared/services/common.service';
import { Injectable } from '@angular/core';
import { DropdownOption } from 'src/app/shared/interfaces/FormField';

@Injectable()
export class CourseService extends CommonService {
  override get entity(): string {
    return 'Course';
  }
  constructor(http: HttpClient) {
    super(http);
  }
  getTeachers(): Observable<DropdownOption[]> {
    return this.http.get<any>(`${environment.apiUrl}Staff`).pipe(
      map((response: PaginationResponse) => {
        const options = response.records.map((x) => {
          const option: DropdownOption = {
            code: x.id,
            label: x.fullName,
          };
          return option;
        });
        return options;
      })
    );
  }

  getClassesList(): Observable<{ id: number; name: string }[]> {
    return this.http.get<{ id: number; name: string }[]>(
      `${environment.apiUrl}Course/GetClassesList`
    );
  }
}
