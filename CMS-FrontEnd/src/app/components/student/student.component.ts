import { Action, PaginationChangParams } from './../../shared/interfaces/Table';
import { switchMap, tap } from 'rxjs';
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
  actions: Action[] = [
    {
      code: 'approve',
      label: 'Approve',
      icon: 'check_circle_outline',
    },
  ];
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
      'approved',
    ];
  }
  ngOnInit() {
    this.getStudents().subscribe();
  }

  getStudents() {
    this.isLoading = true;
    return this.studentService.GetWithPagination(this.pagination).pipe(
      tap((response: PaginationResponse) => {
        this.records = response;
        this.isLoading = false;
      })
    );
  }
  deleteStudent(id: number) {
    this.studentService
      .Delete(id)
      .pipe(
        tap(() => this.openNotification()),
        switchMap(() => this.getStudents())
      )
      .subscribe();
  }
  onChangePagination(event: PaginationChangParams) {
    this.pagination.PageIndex = event.pageIndex;
    this.pagination.PageSize = event.pageSize;
    this.getStudents().subscribe();
  }
  executeAction(data: { data: any; code: string }) {
    console.log(data);
    if (data.code === 'approve') {
      this.studentService
        .approveStudent(data.data.id)
        .pipe(
          tap(() => this.openNotification()),
          switchMap(() => this.getStudents())
        )
        .subscribe();
    }
  }
}
