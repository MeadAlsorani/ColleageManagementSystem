import { Menu } from './../../interfaces/Menu';
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
  @Input() isLoading = true;
  displayColumns: string[] = [];
  _columns: string[] = [];
  @Output() deleteRecordEmitter = new EventEmitter();
  @Input() pageTitle = '';
  @Input() controllerName: string = '';
  @Input() records: any[] = [];
  @Input() set columns(value: string[]) {
    this.displayColumns = [...[], ...value];
    this.displayColumns.push('actions');
    this._columns = value;
  }
  get columns() {
    return this._columns;
  }
  tableConstraints: {
    AllowAdd: boolean;
    AllowDelete: boolean;
    AllowEdit: boolean;
  } = { AllowAdd: false, AllowDelete: false, AllowEdit: false };
  constructor(injector: Injector) {
    super(injector);
  }

  ngOnInit() {
    this.commonService.getAppMenus().subscribe((menus: Menu[]) => {
      const menu = menus.find((x) => x.title == this.controllerName);
      this.tableConstraints.AllowAdd = menu?.actions.includes('add') ?? false;
      this.tableConstraints.AllowEdit = menu?.actions.includes('edit') ?? false;
      this.tableConstraints.AllowDelete =
        menu?.actions.includes('delete') ?? false;
    });
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
