import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-table',
  templateUrl: './table.component.html',
  styleUrls: ['./table.component.less'],
})
export class TableComponent implements OnInit {
  @Input() controllerName: string = '';
  @Input() records: any[] = [];
  @Input() columns: string[] = [];
  constructor() {}

  ngOnInit() {}
}
