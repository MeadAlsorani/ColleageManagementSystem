import { switchMap, tap } from 'rxjs';
import { CourseService } from './../shared/course.service';
import { BaseComponent } from './../../../shared/components/Base.component';
import { Component, OnInit, Injector } from '@angular/core';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';
import { Action, PaginationChangParams } from 'src/app/shared/interfaces/Table';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.css'],
})
export class CoursesComponent extends BaseComponent implements OnInit {
  records: PaginationResponse = { count: 0, records: [] };
  columns: string[] = [
    'className',
    'name',
    'teacher',
    'startDate',
    'endDate',
    'price',
  ];

  buttons: Action[] = [];
  isLoading: boolean = true;
  constructor(injector: Injector, private courseService: CourseService) {
    super(injector);
  }

  ngOnInit() {
    this.getCourses().subscribe();
  }
  search(event: string) {
    if(true){
      this.pagination.SearchStatement = event;
      this.getCourses().subscribe();
    }
  }
  getCourses() {
    this.isLoading = true;
    return this.courseService.GetWithPagination(this.pagination).pipe(
      tap((response) => {
        this.records = response;
        this.isLoading = false;
      })
    );
  }
  deleteCourse(id: number) {
    this.courseService
      .Delete(id)
      .pipe(
        tap(() => this.openNotification()),
        switchMap(() => this.getCourses())
      )
      .subscribe();
  }
  executeAction(event: { data: any; code: string }) {}
  paginationChanged(event: PaginationChangParams) {
    this.pagination.PageSize = event.pageSize;
    this.pagination.PageIndex = event.pageIndex;
    this.getCourses().subscribe();
  }
}
