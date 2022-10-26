import { tap } from 'rxjs';
import { OutcomeService } from './shared/outcome.service';
import { BaseComponent } from './../../shared/components/Base.component';
import { PaginationChangParams } from './../../shared/interfaces/Table';
import { PaginationResponse } from './../../shared/interfaces/Request';
import { Component, OnInit, Injector } from '@angular/core';
import { Action } from 'src/app/shared/interfaces/Table';

@Component({
  selector: 'app-outcome',
  templateUrl: './outcome.component.html',
  styleUrls: ['./outcome.component.less'],
})
export class OutcomeComponent extends BaseComponent implements OnInit {
  columns: string[] = ['type', 'description', 'amount', 'date'];
  buttons: Action[] = [];
  records: PaginationResponse = { count: 0, records: [] };
  isLoading = true;
  constructor(injector: Injector, private outcomeService: OutcomeService) {
    super(injector);
  }

  ngOnInit() {
    this.getData().subscribe();
  }
  getData() {
    return this.outcomeService.GetWithPagination(this.pagination).pipe(
      tap((response) => {
        this.records = response;
        this.isLoading = false;
      })
    );
  }
  onPaginationChanged(event: PaginationChangParams) {
    this.pagination.PageIndex = event.pageIndex;
    this.pagination.PageSize = event.pageSize;
    this.getData().subscribe();
  }
  search(event: string) {
    if(true){
      this.pagination.SearchStatement = event;
      this.getData().subscribe();
    }
  }
}
