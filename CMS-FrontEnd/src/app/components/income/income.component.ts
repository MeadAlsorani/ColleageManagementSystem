import { tap } from 'rxjs';
import { IncomeService } from './shared/income.service';
import { BaseComponent } from './../../shared/components/Base.component';
import { PaginationChangParams } from './../../shared/interfaces/Table';
import { PaginationResponse } from './../../shared/interfaces/Request';
import { Component, OnInit, Injector } from '@angular/core';
import { Action } from 'src/app/shared/interfaces/Table';

@Component({
  selector: 'app-income',
  templateUrl: './income.component.html',
  styleUrls: ['./income.component.less'],
})
export class IncomeComponent extends BaseComponent implements OnInit {
  records: PaginationResponse = { count: 0, records: [] };
  buttons: Action[] = [];
  columns: string[] = ['studentName', 'courseName', 'date', 'amount'];
  isLoading = true;

  constructor(injector: Injector, private incomeService: IncomeService) {
    super(injector);
  }

  ngOnInit() {
    this.getIncomeTransactions().subscribe();
  }

  getIncomeTransactions() {
    return this.incomeService.GetWithPagination(this.pagination).pipe(
      tap((response) => {
        this.records = response;
        console.log(this.records.records[0].courseName);

        this.isLoading = false;
      })
    );
  }
  executeAction(event: PaginationChangParams) {}
  paginationChanged(event: PaginationChangParams) {
    this.pagination.PageIndex = event.pageIndex;
    this.pagination.PageSize = event.pageSize;
    this.getIncomeTransactions().subscribe();
  }
}
