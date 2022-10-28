import { Component, OnInit, Injector, Input } from '@angular/core';
import { BaseComponent } from 'src/app/shared/components/Base.component';
import { PaginationResponse } from 'src/app/shared/interfaces/Request';
import { StudentService } from '../student.service';

@Component({
  selector: 'app-courses-balance',
  templateUrl: './courses-balance.component.html',
  styleUrls: ['./courses-balance.component.less'],
})
export class CoursesBalanceComponent extends BaseComponent implements OnInit {
  records: PaginationResponse = { count: 0, records: [] };
  columns: string[];
  isLoading = true;
  @Input() set id(value: number) {
    if (value != null) {
      this.getData(value);
    }
  }
  constructor(injector: Injector, private studentService: StudentService) {
    super(injector);
    this.columns = ['name', 'price', 'paid', 'remains'];
  }

  ngOnInit() {}

  getData(id: number) {
    this.studentService.courseBalances(id).subscribe((response: any) => {
      const records = response as any[];
      this.records = {
        count: records.length,
        records: records,
      };
      this.isLoading = false;
    });
  }
}
