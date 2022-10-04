import { BaseComponent } from './../Base.component';
import { TranslateService } from '@ngx-translate/core';
import {
  Component,
  EventEmitter,
  Input,
  OnInit,
  Output,
  Injector,
} from '@angular/core';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.less'],
})
export class TableComponent extends BaseComponent implements OnInit {
  displayColumns: string[] = [];
  _columns: string[] = [];
  @Output() deleteRecordEmitter = new EventEmitter();
  @Input() controllerName: string = '';
  @Input() records: any[] = [];
  @Input() set columns(value: string[]) {
    this.displayColumns = [...this.displayColumns, ...value];
    this._columns = value;
  }
  get columns() {
    return this._columns;
  }
  constructor(injector: Injector) {
    super(injector);
  }

  ngOnInit() {
    setTimeout(() => {
      this.displayColumns.push('actions');
    }, 400);
  }
  navigateToEdit() {}
  deleteRecord(record: any) {
    if (
      confirm(this.translateService.instant('Are you sure delete this record'))
    ) {
      this.deleteRecordEmitter.emit(record.id.toString());
    }
  }
}
