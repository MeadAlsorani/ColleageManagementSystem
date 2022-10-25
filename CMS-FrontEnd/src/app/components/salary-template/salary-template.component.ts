import { tap, switchMap } from 'rxjs';
import { LoansListComponent } from './loan/loans-list/loans-list.component';
import { BaseComponent } from './../../shared/components/Base.component';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';
import { Component, OnInit, Injector } from '@angular/core';
import { Action, PaginationChangParams } from 'src/app/shared/interfaces/Table';
import { SalaryTemplateService } from './shared/salary-template.service';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-salary-template',
  templateUrl: './salary-template.component.html',
  styleUrls: ['./salary-template.component.less'],
})
export class SalaryTemplateComponent extends BaseComponent implements OnInit {
  columns: string[] = [
    'staff',
    'salaryPerHour',
    'totalDuration',
    'basicSalary',
  ];
  buttons: Action[] = [
    {
      code: 'loans',
      icon: '',
      label: 'Loans',
    },
  ];
  records: PaginationResponse = { count: 0, records: [] };
  isLoading = true;
  constructor(
    injector: Injector,
    private salaryService: SalaryTemplateService,
    private dialog: MatDialog
  ) {
    super(injector);
  }

  ngOnInit() {
    this.getData().subscribe();
  }
  getData() {
    this.isLoading = true;
    return this.salaryService.GetWithPagination(this.pagination).pipe(
      tap((response: any) => {
        this.isLoading = false;
        this.records = response;
      })
    );
  }
  paginationChanged(event: PaginationChangParams) {
    this.pagination.PageIndex = event.pageIndex;
    this.pagination.PageSize = event.pageSize;
    this.getData().subscribe();
  }
  executeAction(event: { data: any; code: string }) {
    if (event.code === 'loans') {
      this.router.navigate(['../', event.data.id, 'loans'], {
        relativeTo: this.route,
      });
    }
  }
  deleteSalaryTemplate(key: any) {
    this.salaryService
      .Delete(key)
      .pipe(
        tap(() => {
          this.openNotification();
        }),
        switchMap(() => this.getData())
      )
      .subscribe();
  }
}
