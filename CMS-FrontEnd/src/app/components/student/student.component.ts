import { AttendanceDialogComponent } from './shared/attendance-dialog/attendance-dialog.component';
import { AttendanceComponent } from './../attendance/attendance.component';
import { Action, PaginationChangParams } from './../../shared/interfaces/Table';
import { switchMap, tap } from 'rxjs';
import { StudentService } from './shared/student.service';
import { BaseComponent } from './../../shared/components/Base.component';
import {
  Component,
  OnInit,
  Injector,
  ViewChild,
  AfterViewInit,
  Inject,
  ViewChildren,
  QueryList,
  ContentChildren,
  ElementRef,
} from '@angular/core';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';
import { MatDialog } from '@angular/material/dialog';
import { ComponentType } from '@angular/cdk/portal';
import { AuthService } from '../Authentication/auth.service';
import { DOCUMENT } from '@angular/common';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.less'],
})
export class StudentComponent
  extends BaseComponent
  implements OnInit, AfterViewInit
{
  @ViewChild('attendanceTemp') attendanceTemp?: ComponentType<any>;
  @ViewChild('courseBalance') courseBalance?: ComponentType<any>;
  columns: string[];
  isLoading = true;
  selectedId = 0;
  actions: Action[] = [
    {
      code: 'approve',
      label: 'Approve',
      icon: 'check_circle_outline',
    },
    {
      code: 'attendance',
      label: 'Attendance',
      icon: 'show_attendances',
    },
  ];
  records: PaginationResponse = { count: 0, records: [] };
  constructor(
    injector: Injector,
    private studentService: StudentService,
    private dialog: MatDialog,
    private authService: AuthService,
    private elRef: ElementRef
  ) {
    super(injector);
    this.columns = [
      'fullName',
      'nationalId',
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
    const user = this.authService.userData;
    if (['Admin', 'Accountant'].indexOf(user.role) != -1) {
      this.actions.push({
        code: 'courses',
        icon: '',
        label: 'Financial Situation',
      });
    }
  }
  ngAfterViewInit(): void {
    const htmlDoc = this.elRef.nativeElement as HTMLElement;
    const elements = htmlDoc.getElementsByClassName(
      'approved-Students'
    ) as HTMLCollection;

    setTimeout(() => {}, 1500);
  }
  search(event: string) {
    if (true) {
      this.pagination.SearchStatement = event;
      this.getStudents().subscribe();
    }
  }
  getStudents() {
    this.isLoading = true;
    return this.studentService.GetWithPagination(this.pagination).pipe(
      tap((response: PaginationResponse) => {
        setTimeout(() => {
          const htmlDoc = this.elRef.nativeElement as HTMLElement;
          const elements = htmlDoc.getElementsByClassName(
            'approved-Students'
          ) as HTMLCollection;
          const el = elements.namedItem('approved-Students');
          el?.addEventListener('click', () => {
            console.log('sssssssssssssssssssss');
            const classes = el.classList as DOMTokenList;
            if (classes.contains('filtered')) {
              classes.remove('filtered');
              this.pagination.SearchStatement = '';
              this.getStudents().subscribe();
            } else if (this.pagination.SearchStatement == '$approved') {
              classes.add('filtered');
            } else {
              classes.add('filtered');
              this.isLoading = true;
              this.pagination.SearchStatement = '$approved';
              this.getStudents().subscribe();
            }
          });
        }, 1000);
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
    } else if (data.code === 'attendance') {
      this.selectedId = data.data.id;
      this.dialog.open(this.attendanceTemp!);
    } else if (data.code === 'courses') {
      console.log(data.data);
      this.selectedId = data.data.id;
      this.dialog.open(this.courseBalance!, {
        width: '60%',
      });
    }
  }
}
