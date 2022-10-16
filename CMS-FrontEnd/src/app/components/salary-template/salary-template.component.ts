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
    this.getData();
  }
  getData() {
    this.isLoading = true;
    this.salaryService
      .GetWithPagination(this.pagination)
      .subscribe((response) => {
        this.isLoading = false;
        this.records = response;
      });
  }
  paginationChanged(event: PaginationChangParams) {
    this.pagination.PageIndex = event.pageIndex;
    this.pagination.PageSize = event.pageSize;
    this.getData();
  }
  executeAction(event: { data: any; code: string }) {
    if (event.code === 'loans') {
      this.router.navigate(['../', event.data.id, 'loans'], {
        relativeTo: this.route,
      });
    }
  }
}
