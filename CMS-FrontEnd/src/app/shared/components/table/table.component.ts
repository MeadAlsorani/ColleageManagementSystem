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
import { PaginationResponse } from '../../interfaces/Request';
import { Action, PaginationChangParams } from '../../interfaces/Table';

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
  @Output() paginationChangedEmitter = new EventEmitter();
  @Input() pageTitle = '';
  @Input() controllerName: string = '';
  @Input() buttons: Action[] = [];
  @Input() records: PaginationResponse = { count: 0, records: [] };
  @Output() executeAction = new EventEmitter();
  @Input() set columns(value: string[]) {
    this.displayColumns = [...[], ...value];
    this.displayColumns.push('actions');
    this._columns = value;
  }
  get columns() {
    return this._columns;
  }
  @Input() tableConstraints: {
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
      this.tableConstraints.AllowAdd =
        menu?.actions.includes('add') ?? this.tableConstraints.AllowAdd;
      this.tableConstraints.AllowEdit =
        menu?.actions.includes('edit') ?? this.tableConstraints.AllowEdit;
      this.tableConstraints.AllowDelete =
        menu?.actions.includes('delete') ?? this.tableConstraints.AllowDelete;
    });
  }
  navigateToEdit(id: number) {
    this.router.navigate(['../edit', id], { relativeTo: this.route });
  }
  deleteRecord(record: any) {
    if (
      confirm(this.translateService.instant('Are you sure delete this record'))
    ) {
      this.deleteRecordEmitter.emit(record.id.toString());
    }
  }
  paginationChanged(event: PaginationChangParams) {
    this.pagination.PageSize = event.pageSize;
    this.pagination.PageIndex = event.pageIndex;
    this.paginationChangedEmitter.emit(event);
  }

  emitAction(data: any, code: string) {
    this.executeAction.emit({ code, data });
  }
}
