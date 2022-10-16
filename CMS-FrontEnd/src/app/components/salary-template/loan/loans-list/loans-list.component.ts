import { BaseComponent } from './../../../../shared/components/Base.component';
import { SalaryTemplateService } from './../../shared/salary-template.service';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';
import { Component, OnInit, Injector } from '@angular/core';

@Component({
  selector: 'app-loans-list',
  templateUrl: './loans-list.component.html',
  styleUrls: ['./loans-list.component.less'],
})
export class LoansListComponent extends BaseComponent implements OnInit {
  columns: string[] = ['amount', 'date'];
  records: PaginationResponse = { count: 0, records: [] };
  constructor(
    private salaryService: SalaryTemplateService,
    injector: Injector
  ) {
    super(injector);
  }

  ngOnInit() {
    this.route.params.subscribe((params) => {
      this.getData(+params['id']);
    });
  }
  getData(id: number) {
    this.salaryService.getLoans(id).subscribe((response) => {
      this.records = response;
    });
  }
  deleteLoan(id: number) {
    this.salaryService.deleteLoan(id).subscribe();
  }
}
