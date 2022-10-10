import { PaginationChangParams } from './../../shared/interfaces/Table';
import { tap } from 'rxjs';
import { StudentService } from './shared/student.service';
import { BaseComponent } from './../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.less'],
})
export class StudentComponent extends BaseComponent implements OnInit {
  columns: string[];
  isLoading = true;
  records: PaginationResponse = { count: 0, records: [] };
  constructor(injector: Injector, private studentService: StudentService) {
    super(injector);
    this.columns = [
      'fullName',
      'guardianName',
      'phoneNumber',
      'classLevel',
      'schoolName',
      'registerationDate',
    ];
  }
  ngOnInit() {
    this.getStudents();
  }

  getStudents() {
    this.isLoading = true;
    this.studentService
      .GetWithPagination(this.pagination)
      .pipe(
        tap((response: PaginationResponse) => {
          this.records = response;
          this.isLoading = false;
        })
      )
      .subscribe();
  }
  deleteStudent(id: number) {
    this.studentService.Delete(id).subscribe(() => {
      this.openNotification();
      this.getStudents();
    });
  }
  onChangePagination(event: PaginationChangParams) {
    this.pagination.PageIndex = event.pageIndex;
    this.pagination.PageSize = event.pageSize;
    this.getStudents();
  }
}
